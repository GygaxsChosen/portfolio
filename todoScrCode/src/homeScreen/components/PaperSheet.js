import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';
import TextField from '@material-ui/core/TextField';
import 'date-fns';
import  {MaterialUIPickers} from '../../../src/homeScreen/components/DatePicker'
import '../../../src/App.css'
import {TimePicker} from '../../../src/homeScreen/components/TimePicker'
import {DescriptionField} from '../../../src/homeScreen/components/DescriptionField'
import {SaveButton} from '../../../src/homeScreen/components/SaveButton'




export default class PaperSheet extends React.Component{

    constructor(props) {
        super(props);
        this.handleNameChange = this.handleNameChange.bind(this);
        this.handleDateChange=this.handleDateChange.bind(this);
        this.handleDescriptionChange = this.handleDescriptionChange.bind(this);
        this.handleSave =this.handleSave.bind(this);
        this.handleTimeChange =this.handleTimeChange.bind(this)

        this.state = {
            name: '',
            date: '',
            time: '',
            description: '',
            renderPaper: false,
        }
    }
    handleDescriptionChange(e){

this.setState({description: e.target.value})
    }

    handleDateChange(date){
        this.setState({date: date})

    }

    handleTimeChange(time){
        debugger;
this.setState({time: time})
    }

    handleNameChange(e){


this.setState({name: e.target.value})
    }

    handleSave(){
        this.props.pullUpRenderStatus();
    }

render() {
        const {classes} =this.props;
    return (
        <div>{this.props.renderPaper &&
        <Paper className={classes.root}>
            <Typography variant="h5" component="h3">
                <TextField
                    id="standard-bare"
                    className={classes.textField}
                    defaultValue="name"
                    margin="normal"
                    onChange={(e)=>this.handleNameChange(e)}
                    inputProps={{ 'aria-label': 'bare' }}
                />
            </Typography>
            <br/>
            <div className='datePicker'>
                <MaterialUIPickers pullDateForward={this.handleDateChange} />
                <TimePicker pullTimeForward={this.handleTimeChange}/>
            </div>
            <br/>
            <DescriptionField pullDescriptionForward={this.handleDescriptionChange} />
            <SaveButton handleSave={this.handleSave}/>



        </Paper>
        }

        </div>
    );
}


}