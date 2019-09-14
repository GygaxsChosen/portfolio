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
import {red} from "@material-ui/core/colors";




export default class PaperSheet extends React.Component{

    constructor(props) {




        super(props);
        this.handleNameChange = this.handleNameChange.bind(this);
        this.handleDateChange=this.handleDateChange.bind(this);
        this.handleDescriptionChange = this.handleDescriptionChange.bind(this);
        this.handleSave =this.handleSave.bind(this);
        this.handleTimeChange =this.handleTimeChange.bind(this);
        this.checkForErrors =this.checkForErrors.bind(this);

        this.state = {
            name: '',
            date: '',
            time: '',
            description: '',
            renderPaper: false,
            showErrorText: false,
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
    checkForErrors(){
        debugger;
        if (!this.state.name||
            !this.state.description||
            !this.state.date||
            !this.state.time
        ){
            return true
        }
        else {
            return false
        }
    }

    handleSave() {
        const uuidv1 = require('uuid/v1');
        let newID = uuidv1();

        const hasErrors = this.checkForErrors();

        if (!hasErrors) {

        const noteObject = {
            name: this.state.name,
            description: this.state.description,
            date: this.state.date.toDateString(),
            time: this.state.time.toDateString(),
            noteId: newID,
        };

        firebase.database().ref('accounts/' + this.props.user.uid + '/' + 'notes/' + newID).set(noteObject)


        this.props.pullUpRenderStatus();
    }else {
            this.setState({showErrorText: true})
        }


    }

render() {
        const {classes} =this.props;


    var styles1 = {
     color:'red',
        backgroundColor: 'pink'
    };

    return (
        <div>{this.props.renderPaper &&
        <Paper className={classes.root}>
            {this.state.showErrorText &&
            <h1 style={styles1}>Please fill out the entire form</h1>
            }


            <Typography variant="h5" component="h3">
                <TextField
                    label={'Name of Task:'}
                    id="standard-bare"
                    className={classes.textField}
                    defaultValue=""
                    margin="normal"
                    onChange={(e)=>this.handleNameChange(e)}
                    inputProps={{ 'aria-label': 'bare' }}
                />
            </Typography>
            <br/>
            <div className='datePicker'>
                <MaterialUIPickers pullDateForward={this.handleDateChange}  />
                <TimePicker pullTimeForward={this.handleTimeChange}/>
            </div>
            <br/>
            <DescriptionField pullDescriptionForward={this.handleDescriptionChange} />
            <SaveButton unrenderMainPanel={this.props.unrenderMainPanel} handleSave={this.handleSave}/>



        </Paper>
        }

        </div>
    );
}


}
