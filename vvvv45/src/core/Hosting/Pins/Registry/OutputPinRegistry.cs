﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using VVVV.PluginInterfaces.V2;
using VVVV.PluginInterfaces.V1;
using VVVV.Hosting.Pins.Output;
using VVVV.Utils.VMath;
using VVVV.Utils.VColor;

using SlimDX;


namespace VVVV.Hosting.Pins
{
    public class OutputPinRegistry : PinTypeRegistry<OutputAttribute>
    {
        public OutputPinRegistry()
        {
            //Register default types
            this.RegisterType(typeof(double), (host, attribute) => new DoubleOutputPin(host, attribute));
            this.RegisterType(typeof(float), (host, attribute) => new FloatOutputPin(host, attribute));
            this.RegisterType(typeof(int), (host, attribute) => new IntOutputPin(host, attribute));
            this.RegisterType(typeof(bool), (host, attribute) => new BoolOutputPin(host, attribute));

            this.RegisterType(typeof(Matrix4x4), (host, attribute) => new Matrix4x4OutputPin(host, attribute));
            this.RegisterType(typeof(Matrix), (host, attribute) => new SlimDXMatrixOutputPin(host, attribute));

            this.RegisterType(typeof(Vector2D), (host, attribute) => new Vector2DOutputPin(host, attribute));
            this.RegisterType(typeof(Vector3D), (host, attribute) => new Vector3DOutputPin(host, attribute));
            this.RegisterType(typeof(Vector4D), (host, attribute) => new Vector4DOutputPin(host, attribute));

            this.RegisterType(typeof(Vector2), (host, attribute) => new Vector2OutputPin(host, attribute));
            this.RegisterType(typeof(Vector3), (host, attribute) => new Vector3OutputPin(host, attribute));
            this.RegisterType(typeof(Vector4), (host, attribute) => new Vector4OutputPin(host, attribute));

            this.RegisterType(typeof(string), (host, attribute) => new StringOutputPin(host, attribute));
            this.RegisterType(typeof(RGBAColor), (host, attribute) => new ColorOutputPin(host, attribute));

            this.RegisterType(typeof(EnumEntry), (host, attribute) => new DynamicEnumOutputPin(host, attribute));
        }
    }
}