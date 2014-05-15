/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// RecipesUnmarshaller
      /// </summary>
      internal class RecipesUnmarshaller : IUnmarshaller<Recipes, XmlUnmarshallerContext>, IUnmarshaller<Recipes, JsonUnmarshallerContext>
      {
        Recipes IUnmarshaller<Recipes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Recipes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Recipes recipes = new Recipes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Setup", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                recipes.Setup = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Configure", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                recipes.Configure = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Deploy", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                recipes.Deploy = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Undeploy", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                recipes.Undeploy = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Shutdown", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                recipes.Shutdown = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return recipes;
        }

        private static RecipesUnmarshaller instance;
        public static RecipesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new RecipesUnmarshaller();
            return instance;
        }
    }
}
  