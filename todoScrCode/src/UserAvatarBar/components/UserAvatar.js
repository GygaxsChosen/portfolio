import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Avatar from '@material-ui/core/Avatar';
import { deepOrange, deepPurple } from '@material-ui/core/colors';
import Grid from '@material-ui/core/Grid';

const useStyles = makeStyles({

    purpleAvatar: {
        margin: 10,
        color: '#fff',
        backgroundColor: deepPurple[500],
        cursor: 'pointer'
    },
});

export default function UserAvatar() {
    const classes = useStyles();

    return (
        <Grid container justify="center" alignItems="center">
            <Avatar className={classes.purpleAvatar}>G</Avatar>
        </Grid>
    );
}