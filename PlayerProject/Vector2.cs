using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Author : Joanne Jung
 * Date : Jun3 17, 2016
 * Student Number : 300432364
 * Description : The class is used to describe x and y coordinates for an object
 * Version : 0.0.1 - Initial Class creation with GEtters and Setters for x and y
 */
namespace PlayerProject
{

    /**
     * <summary>
     * This class contains two properties, x and y, which are related to geospatial information for GameObject
     * </summary>
     * 
     * @class Vector2
     * @property {float} x - defines the x coordinate
     * @property {float} y - defines the y coordinate
     * @return {void}
     */
    public class Vector2
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private float _x;
        private float _y;

        // CONSTRUCTORS 
        /**
         * <summary>
         * This constructor takes two paramaters, x and y, which represents the x and y coordinates of an object
         * </summary>
         * 
         * @constructor Vector2
         * @param {float} x - x coordinate
         * @param {float} y - y coordinate
         */ 
        public Vector2(float x = 0f, float y= 0f)
        {
            this.x = x;
            this.y = y;
        }

        // PUBLIC PROPERTIES 
        public float x
        {
            get
            {
                return this._x;
            }

            set
            {
                this._x = value;
            }
        }

        public float y
        {
            get
            {
                return this._y;
            }

            set
            {
                this._y = value;
            }
        }

        // PUBLIC METHODS
        public void Zero()
        {
            this.x = 0f;
            this.y = 0f;
        }
    }
}