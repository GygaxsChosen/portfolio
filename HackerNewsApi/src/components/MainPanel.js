import React from 'react';

export  class MainPanel extends React.Component{

    constructor(props){
        super(props)
        this.state={
            StorysToRender: [],
            indexOfTopTen: 0,
            topStories: [],
        }

        this.fetchTopStories =this.fetchTopStories.bind(this);
        this.populateTopTen =this.populateTopTen.bind(this);
        this.handleLoadMore = this.handleLoadMore.bind(this);

    }
     async componentDidMount() {

        let topStories = await this.fetchTopStories()
         const topTen = topStories.slice(0,10);

         const dataOfTopTen = await this.populateTopTen(topTen);
         this.setState({StorysToRender: dataOfTopTen, indexOfTopTen: 10, topStories: topStories});


    }

    async handleLoadMore(){
        const {topStories, indexOfTopTen, StorysToRender} =this.state;

        let newStoryIds = topStories.slice(indexOfTopTen, indexOfTopTen + 10);
        debugger;

        const newStories = await this.populateTopTen(newStoryIds);
        let newStoryListToRender = StorysToRender.concat(newStories) ;
        debugger;

        this.setState({StorysToRender: newStoryListToRender});

    }
     async populateTopTen(topTen) {
         return await Promise.all(
             topTen.map(async (topItem) => {

                 const result = await fetch(`https://hacker-news.firebaseio.com/v0/item/${topItem}.json?print=pretty`)
                 const resultJSON = result.json();

                 return resultJSON

             })
         )
     }



    async fetchTopStories(){
        let result =[];
         await fetch('https://hacker-news.firebaseio.com/v0/topstories.json?print=pretty')
            .then((response) => response.json())
            .then((responseJSON) => {
                result = responseJSON;
            });
         return result;

    }

    render(){
        const {StorysToRender}=this.state
        return(
            <div>

                <input type="text" placeholder="Search.."/>
                {StorysToRender.map((story) =>{
                    return (<div>
                            <div className='storyBox'>
                                <p >{story.title} <p/> written by: {story.by} </p>
                                <a href={story.url}>{story.url}</a>
                            </div>
                            <br/>
                            <br/>
                        </div>
                        )

                })}
<button onClick={this.handleLoadMore} >Load more</button>
            </div>
        )
    }


}
