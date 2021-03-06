import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';

const useStyles = makeStyles(theme => ({
    button: {
        margin: theme.spacing(1),
    },
    input: {
        display: 'none',
    },
}));

export const  LogInButtons=(props)=> {
    const classes = useStyles();


    return (
        <div>
            <Button variant="contained" color="primary" className={classes.button} onClick={props.handleAccountCreation}>
                Login with Google
            </Button>
            <Button variant="contained" color="secondary" className={classes.button} onClick={props.handleGuestClick}>
                Continue as Guest
            </Button>


        </div>
    );
}