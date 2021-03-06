///////////////////////////////////////////////////////////
//  YardHandler.cs
//  Implementation of the Class YardHandler
//  Generated by Enterprise Architect
//  Created on:      19-Mar-2019 7:18:26 PM
///////////////////////////////////////////////////////////


namespace LengthConversionProgram
{

    public class YardHandler : ConversionHandler
    {

        public override void HandleConversion(string unitRequested, ConversionRequest currentRequest)
        {
            if (unitRequested == "Yard")
            {
                currentRequest.Output = currentRequest.Input * 1093.61;
            }
            else
            {
                successor.HandleConversion(unitRequested, currentRequest);
            }
        }

    }
}