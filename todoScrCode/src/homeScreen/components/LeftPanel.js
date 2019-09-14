import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Drawer from '@material-ui/core/Drawer';
import CssBaseline from '@material-ui/core/CssBaseline';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import List from '@material-ui/core/List';
import Typography from '@material-ui/core/Typography';
import Divider from '@material-ui/core/Divider';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import InboxIcon from '@material-ui/icons/MoveToInbox';
import MailIcon from '@material-ui/icons/Mail';
import CreateIcon from '@material-ui/icons/Create';
import {StyledPaper} from '../../../src/homeScreen/components/StyledPaper'
import LoginCard from '../../../src/LoginScreen/LoginCard'
import UserAvatar from "../../UserAvatarBar/components/UserAvatar";
import * as firebase from "firebase";
import SavedNotesIcon from '../../../src/homeScreen/components/SavedNotesIcon.js'
import Badge from '@material-ui/core/Badge';
import {StyledSavedNote} from "../../../src/homeScreen/components/StyledSavedNote.js";

export default class LeftPanel extends React.Component {

    constructor(props) {

        super(props);
        this.state = {
            renderPaper: false,
            renderSavedNote: false,
            UserLoggedIn: false,
            username:'',
            user:'',
            notes: [],
            selectedNote:''
        };

        this.handleNewToDo = this.handleNewToDo.bind(this);
        this.pullUpRenderStatus =this.pullUpRenderStatus.bind(this);
        this.handleLogin =this.handleLogin.bind(this);
        this.fetchSavedNotes =this.fetchSavedNotes.bind(this);
        this.renderReadingNotes =this.renderReadingNotes.bind(this);
        this.unrenderSavedNotes =this.unrenderSavedNotes.bind(this);
        this.nextNote =this.nextNote.bind(this);
        this.previousNote =this.previousNote.bind(this);
        this.delete =this.delete.bind(this);
        this.unrenderMainPanel = this.unrenderMainPanel.bind(this);
    }
    unrenderMainPanel(){
        this.setState({renderPaper: false});
    }

    async fetchSavedNotes(){
        //this needs to return saved notes.
        let path = `/accounts/${this.state.user.uid}/notes`;

        let foundNotes = await firebase.database().ref(path).once('value');
        let notes= foundNotes.val();
        if(notes){
            const arrayofNotes = Object.values(notes);
            this.setState({notes: arrayofNotes});
        }else{
            this.setState({notes: []});
        }


    }
    async delete(){
        var db = firebase.firestore();
        let selectedNote = this.state.notes[this.state.selectedNote]

        let path =`accounts/${this.state.user.uid}/notes/${selectedNote.noteId}`
        await firebase.database().ref(path).remove();

        this.fetchSavedNotes();


    }
    nextNote(){
        if (this.state.selectedNote === this.state.notes.length -1){
            this.setState({selectedNote: 0})
        }else {
            this.setState({selectedNote: this.state.selectedNote + 1})
        }

    }

    previousNote(){
        if(this.state.selectedNote === 0){
            this.setState({selectedNote : this.state.notes.length-1})
        }else {
            this.setState({selectedNote: this.state.selectedNote -1})
        }
    }


    renderReadingNotes(){
        debugger;
        this.setState({renderSavedNote:true , selectedNote: 0});

    }
    handleNewToDo(){
        debugger;

        this.setState({renderPaper: true})



    }
    unrenderSavedNotes(){
        this.setState({renderSavedNote:false})
    }

    pullUpRenderStatus(){
        this.setState({renderPaper: false})

        this.fetchSavedNotes();
    }
    async handleLogin(user){
        this.setState({UserLoggedIn:true, user: user});
debugger;
        if (user !== 'guest'){
            const userInfo = {
                displayName: user.displayName,
                email :user.email
            }
            const uuid = user.uid;
            let updates ={};
            let lookup = await firebase.database().ref('/accounts/' + uuid).once('value')
            let result = lookup.val();
            if(!result){
                updates['/accounts/' + uuid] =userInfo;
                return firebase.database().ref().update(updates);
            }
            this.fetchSavedNotes();
        }



    }

    render() {
        const {classes} =this.props
        return (
            <div>
                {!this.state.UserLoggedIn &&
                <div className="">
                    <LoginCard handleLogin={this.handleLogin}/>
                </div>
                }


                {this.state.UserLoggedIn &&
                <div className={classes.root}>
                    <CssBaseline />
                    <AppBar position="fixed" className={classes.appBar}>
                        <Toolbar>
                            <Typography variant="h6" noWrap>
                                To-do list
                            </Typography>
                        </Toolbar>
                    </AppBar>

                    <Drawer
                        className={classes.drawer}
                        variant="permanent"
                        classes={{
                            paper: classes.drawerPaper,
                        }}
                        anchor="left"
                    >
                        <div className={classes.toolbar} />
                      {this.state.user && this.state.user.photoURL &&
                        <UserAvatar profilePic ={this.state.user.photoURL} />
                    }

                        <Divider />

                        <List>
                            <ListItem button onClick={this.handleNewToDo} >
                                <ListItemIcon>
                                    <CreateIcon/>
                                    <ListItemText primary='New Item To-Do' />
                                </ListItemIcon>
                            </ListItem>
                            <Divider/>
                            <ListItem button  onClick={this.renderReadingNotes}>
                                <ListItemIcon>
                                    <Badge badgeContent={this.state.notes.length} color="primary">
                                    <MailIcon />
                                    </Badge>
                                    <ListItemText primary=' saved notes' />


                            </ListItemIcon>

                            </ListItem>

                        </List>
                        <Divider />
                    </Drawer>
                    <main className={classes.content}>
                        <div className={classes.toolbar} />
                        <Typography paragraph>
                            <div>
                                <StyledPaper unrenderMainPanel ={this.unrenderMainPanel} user={this.state.user} database={this.props.database} renderPaper={this.state.renderPaper} pullUpRenderStatus={this.pullUpRenderStatus}/>
                                <br/>
                                <StyledSavedNote
                                    delete={this.delete}
                                    previousNote={this.previousNote}
                                    nextNote={this.nextNote}
                                    database={this.props.database} onClose ={this.unrenderSavedNotes} renderPaper={this.state.renderSavedNote} pullUpRenderStatus={this.pullUpRenderStatus} selectedNote={this.state.notes[this.state.selectedNote]} />
                            </div>
                        </Typography>

                    </main>
                </div>
                }

            </div>

        );
    }


}
