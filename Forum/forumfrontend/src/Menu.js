import React, { Component, useEffect, useState } from 'react';
import axios from 'axios';

function Menu(){
return (
    <div>
        <h1>Select a Thread</h1>
            <select name="tread" id="tread">
              <option value="diy">DIY</option>
              <option value="gaming">Gaming</option>
              <option value="sports">Sports</option>
              <option value="coding">Coding</option>
            </select>
    </div>
    )
}
export default Menu;