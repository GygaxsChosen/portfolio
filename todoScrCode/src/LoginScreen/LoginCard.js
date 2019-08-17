import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import TextField from "@material-ui/core/TextField";
import Typography from "@material-ui/core/Typography";
import '../../src/App.css'
import UserNameField from '../../src/LoginScreen/components/UserNameField'
import {LogInButtons} from "./components/LogInButtons";
import {GuestWarning} from '../../src/LoginScreen/GuestWarning'


export default class LoginCard extends React.Component{

    constructor(props){
        super(props);
        this.passupDataForLogin = this.passupDataForLogin.bind(this);
        this.handleGuestClick = this.handleGuestClick.bind(this);

        this.state={
            userName:'',
            Password:'',
            renderWarning : false,
        }
    }

    passupDataForLogin(){

        this.props.handleLogin()
    }
    handleGuestClick(){

        this.setState({renderWarning: true})

    }

    render() {

        const {handleLogin}=this.props;
        return(
            <div className='paper' >
                {this.state.renderWarning &&
                    <div>
                        <GuestWarning onProceed = {this.props.handleLogin}/>
                    </div>

                }
                <Paper>
                    <Typography variant="h5" component="h3">
                     Please logIn or continue as a guest
                        <br/>
                        <br/>
                        <UserNameField />
                        <br/>
                        <LogInButtons handleLogin={handleLogin} handleGuestClick={this.handleGuestClick}/>
                    </Typography>
                </Paper>
            </div>
        )
    }
}