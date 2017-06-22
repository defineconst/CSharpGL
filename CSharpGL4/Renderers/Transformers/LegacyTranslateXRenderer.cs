﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    public class LegacyTranslateXRenderer : RendererBase, ILegacyPickable
    {
        #region ILegacyPickable 成员

        private LegacyPickingFlags enableLegacyPicking = LegacyPickingFlags.BeforeChildren | LegacyPickingFlags.Children;
        /// <summary>
        /// 
        /// </summary>
        public LegacyPickingFlags EnableLegacyPicking
        {
            get { return this.enableLegacyPicking; }
            set { this.enableLegacyPicking = value; }
        }

        public void RenderBeforeChildrenForLegacyPicking(LegacyPickEventArgs arg)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Render this model after rendering its children in legacy OpenGL.
        /// </summary>
        /// <param name="arg"></param>
        public void RenderAfterChildrenForLegacyPicking(LegacyPickEventArgs arg) { }

        #endregion
    }
}
