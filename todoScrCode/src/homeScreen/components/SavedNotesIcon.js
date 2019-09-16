import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Badge from '@material-ui/core/Badge';
import IconButton from '@material-ui/core/IconButton';
import MailIcon from '@material-ui/icons/Mail';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';

const useStyles = makeStyles(theme => ({
    margin: {
        margin: theme.spacing(2),
    },
    padding: {
        padding: theme.spacing(0, 2),
    },


}));

export default function SavedNotesIcon(props) {
    const classes = useStyles();

    return (
        <div>
            <div>
                <Badge className={classes.margin} badgeContent={props.notes.length} color="primary">
                    <MailIcon onClick={() => props.renderReadingNotes()} />
                </Badge>
            </div>
        </div>
    );
}
