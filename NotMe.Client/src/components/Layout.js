import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';

import { NavMenu } from './NavMenu';

import './Layout.css'
import { Banner } from "./Banner";

export class Layout extends Component {

    render() {
        return(

            <div>
            <NavMenu />
            <Container>
            {this.props.children}
            </Container>
            </div>

        //<Container fluid className="layout-container">
        //    <Row className="layout-container-row">

        //    <Col xs="12" sm="5" lg="3" xl="2"
        //className="layout-sidepanel">
            
        //    <Row className="layout-sidepanel-banner">
        //    <Banner src="images/logo.png" />
        //    </Row>
        //    <Row className="layout-sidepanel-contents">
        //   //TODO: Navbar MENU (Login,Register,Logout, ToDo's etc...)
        //    </Row>

        //    </Col>
        //    <Col xs="12" sm="7" lg="9" xl="10"
        //className="layout-container-contents
        //d-none d-sm-flex flex-column">
            
           
        //    </Col>
        //    </Row>
        //    </Container>
    );
}
}