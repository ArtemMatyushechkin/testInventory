﻿/*  Copyright 2020 Gabriel Pasquale Rodrigues Scavone
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 * 
 * 
 * 
 *  This is the scriptable object ofr non-pattern recipes
 */
 
 using UnityEngine;

namespace UniversalInventorySystem
{

    [AddComponentMenu("UniversalInventorySystem/Recipe"), CreateAssetMenu(fileName = "Recipe", menuName = "UniversalInventorySystem/Recipe", order = 132), System.Serializable]
    public class Recipe : ScriptableObject
    {
        public int numberOfFactors;
        public Item[] factors;
        public int[] amountFactors;

        public int numberOfProducts;
        public Item[] products;
        public int[] amountProducts;

        public int id;
        public string key;
    }
}