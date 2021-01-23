import React, { Component } from 'react'

export class Trips extends Component {
    constructor(props){
        super(props);

        this.state = {
            trips:[],
            loading:false
        }
        this.RenderTaskTable=this.RenderTaskTable.bind(this)
    }
    RenderTaskTable(trips){
        return(
            <table className="table table-stripped">
                <thead>
                <tr>
                <th>Name</th>
                <th>Description</th>
                <th>Date Started</th>
                <th>Date Created</th>
                <th>Action</th>
                </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>a</td>
                        <td>a</td>
                        <td>aa</td>
                        <td>a</td>
                        <td>-</td>
                    </tr>
                    <tr>
                        <td>b</td>
                        <td>b</td>
                        <td>bb</td>
                        <td>c</td>
                        <td>-</td>
                    </tr>
                    <tr>
                        <td>a</td>
                        <td>a</td>
                        <td>aa</td>
                        <td>a</td>
                        <td>-</td>
                    </tr>
                </tbody>
            </table>
        )
    }

    render() {
        let content = this.state.loading?(
            <p>
                <em>Loading...</em>
            </p>
        ):this.RenderTaskTable(this.state.trips)
        return (
            <div>
                <h1>Get all trips</h1>
                {content}
            </div>
        )
    }
}


