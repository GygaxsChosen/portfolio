import React from "react";
import LeftPanel from "./LeftPanel";
import { styled } from '@material-ui/styles';
import {makeStyles} from "@material-ui/core";
import * as firebase from "firebase";
import config from '../../../src/FireBaseConfig'


const drawerWidth = 240;

const useStyles = makeStyles(theme => ({
    root: {
        display: 'flex',
    },
    appBar: {
        width: `calc(100% - ${drawerWidth}px)`,
        marginLeft: drawerWidth,
    },
    drawer: {
        width: drawerWidth,
        flexShrink: 0,
    },
    drawerPaper: {
        width: drawerWidth,
    },
    toolbar: theme.mixins.toolbar,
    content: {
        flexGrow: 1,
        backgroundColor: theme.palette.background.default,
        padding: theme.spacing(3),
    },
}));

export default function StyledComponents(props){
    firebase.initializeApp(config);
    var database = firebase.database();
    const classes = useStyles();
    return <LeftPanel
        database={database}
        classes={classes}
    />
}