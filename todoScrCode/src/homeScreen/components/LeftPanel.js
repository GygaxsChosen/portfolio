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

export default class PermanentDrawerLeft extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            renderPaper: false,
            UserLoggedIn: false,
            username:''
        };

        this.handleNewToDo = this.handleNewToDo.bind(this);
        this.pullUpRenderStatus =this.pullUpRenderStatus.bind(this);
        this.handleLogin =this.handleLogin.bind(this);
    }

    handleNewToDo(){

        this.setState({renderPaper: true})
    }

    pullUpRenderStatus(){
        this.setState({renderPaper: false})
    }
    handleLogin(user){
        this.setState({UserLoggedIn:true, userName: user})
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
                        <UserAvatar/>
                        <Divider />

                        <List>
                            <ListItem button onClick={this.handleNewToDo} >
                                <ListItemIcon>
                                    <CreateIcon/>
                                    <ListItemText primary='New Item To-Do' />
                                </ListItemIcon>
                            </ListItem>

                        </List>
                        <Divider />
                    </Drawer>
                    <main className={classes.content}>
                        <div className={classes.toolbar} />
                        <Typography paragraph>
                            <div>
                                <StyledPaper renderPaper={this.state.renderPaper} pullUpRenderStatus={this.pullUpRenderStatus}/>
                            </div>
                        </Typography>

                    </main>
                </div>
                }

            </div>

        );
    }


}
