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
import * as firebase from "firebase";
import {CloseIcon} from '../../../src/homeScreen/components/CloseIcon.js'




export default class SavedNote extends React.Component{

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

        this.setState({time})
    }

    handleNameChange(e){


        this.setState({name: e.target.value})
    }

    handleSave(){
        const uuidv1 = require('uuid/v1');
        let newID = uuidv1();

        const noteObject ={
            name: this.state.name,
            description: this.state.description,
            date: this.state.date.toDateString(),
            time: this.state.time.toDateString(),
            noteId:newID,
        };

        firebase.database().ref('accounts/' + this.props.user.uid +'/' +'notes/' +newID).set(noteObject)


        this.props.pullUpRenderStatus();
    }

    render() {
        const {classes} =this.props;
        return (
            <div>{this.props.renderPaper && this.props.selectedNote &&
            <Paper className={classes.root}>
                <Typography variant="h5" component="h3">
                    <TextField
                        label={'name of task:'}
                        id="standard-bare"
                        className={classes.textField}
                        //defaultValue="name"
                        value={this.props.selectedNote.name}
                        margin="normal"
                        onChange={(e)=>this.handleNameChange(e)}
                        inputProps={{ 'aria-label': 'bare' }}
                    />
                </Typography>
                <br/>
                <div className='datePicker'>
                    {this.props.selectedNote.date}
                    <br/>
                   {this.props.selectedNote.time}
                </div>
                <br/>
                {this.props.selectedNote.description}
                <CloseIcon delete={this.props.delete} previousNote={this.props.previousNote} nextNote={this.props.nextNote} close={this.props.close}/>

            </Paper>
            }

            </div>
        );
    }


}
