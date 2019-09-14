import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import TextField from "@material-ui/core/TextField";
import Typography from "@material-ui/core/Typography";
import '../../src/App.css'
import UserNameField from '../../src/LoginScreen/components/UserNameField'
import {LogInButtons} from "./components/LogInButtons";
import {GuestWarning} from '../../src/LoginScreen/GuestWarning'
import firebase from "firebase";
import fireBaseConfig from '../../src/FireBaseConfig'

export default class LoginCard extends React.Component{

    constructor(props){
        super(props);
        this.passupDataForLogin = this.passupDataForLogin.bind(this);
        this.handleGuestClick = this.handleGuestClick.bind(this);
        this.handleAccountCreation = this.handleAccountCreation.bind(this);

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
    async handleAccountCreation(){
        var user = 'guest';
        const provider = new firebase.auth.GoogleAuthProvider();
try {
    const result = await firebase.auth().signInWithPopup(provider);


    this.props.handleLogin(result.user);
}catch (e) {

}






    }

    render() {



        const {handleLogin}=this.props;
        return(
            <div className='paper' >
                {this.state.renderWarning &&
                    <div>
                        <GuestWarning onProceed = {()=>this.props.handleLogin('guest')}/>
                    </div>

                }
                <div id="firebaseui-auth-container"></div>

                <Paper>
                    <Typography variant="h5" component="h3">
                     Please login or continue as a guest
                        <br/>
                        <br/>
                        <br/>
                        <LogInButtons handleLogin={handleLogin} handleGuestClick={this.handleGuestClick} handleAccountCreation={this.handleAccountCreation}/>
                    </Typography>
                </Paper>
            </div>
        )
    }
}
