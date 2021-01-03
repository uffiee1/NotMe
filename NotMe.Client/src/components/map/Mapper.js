import React, { Component } from 'react';
import { MapContainer, TileLayer } from 'react-leaflet';
//import './Mapper.css';

export default class Mapper extends Component {
    static displayName = Mapper.name;

    var map = L.map('map', {
        center: [51.505, -0.09],
        zoom: 13
    });

    render() {
        const position = [1.35, 103.8];
        return (
        <MapContainer
        className="map"
        center={position}
        zoom={10}
        style={{ height: 500, width: "100%" }}
    >
    <TileLayer
    attribution='&amp;copy <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
    url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
        />
        </MapContainer>
    );
    }
}