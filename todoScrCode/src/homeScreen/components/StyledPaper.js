import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';
import TextField from '@material-ui/core/TextField';
import PaperSheet from "./PaperSheet";

const useStyles = makeStyles(theme => ({
    root: {
        padding: theme.spacing(3, 2),
    },
    container: {
        display: 'flex',
        flexWrap: 'wrap',
    },
    textField: {
        marginLeft: theme.spacing(1),
        marginRight: theme.spacing(1),
        width: 200,
    },
    dense: {
        marginTop: 19,
    },
    menu: {
        width: 200,
    },

}));



export const StyledPaper= (props)=>{
    const classes = useStyles();

    return <PaperSheet
        unrenderMainPanel={props.unrenderMainPanel}
        user={props.user}
        classes={classes}
        renderPaper={props.renderPaper}
        database={props.database}
        pullUpRenderStatus={props.pullUpRenderStatus}
    />
}
