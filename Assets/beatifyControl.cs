using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beautify.Universal;
using UnityEngine.Rendering;
[ExecuteInEditMode]
public class beatifyControl : MonoBehaviour
{
   [SerializeField] private Volume postProcessing;
   [Range(0f,0.03f)]
   [SerializeField] private float anamorphicFlareValue;

   private void Update()
   {
      anamorphicFlare();
   }

   void anamorphicFlare()
   {
      BeautifySettings.settings.anamorphicFlaresIntensity.Override(anamorphicFlareValue);
   }
}
