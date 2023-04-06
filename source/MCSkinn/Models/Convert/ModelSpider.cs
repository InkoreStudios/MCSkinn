﻿#if CONVERT_MODELS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static MCSkinn.ModelLoader;

namespace MCSkinn.Models.Convert
{
	public class ModelSpider : ModelBase
	{
		/** The spider's head box */
		public ModelRenderer spiderHead;

		/** The spider's neck box */
		public ModelRenderer spiderNeck;

		/** The spider's body box */
		public ModelRenderer spiderBody;

		/** Spider's first leg */
		public ModelRenderer spiderLeg1;

		/** Spider's second leg */
		public ModelRenderer spiderLeg2;

		/** Spider's third leg */
		public ModelRenderer spiderLeg3;

		/** Spider's fourth leg */
		public ModelRenderer spiderLeg4;

		/** Spider's fifth leg */
		public ModelRenderer spiderLeg5;

		/** Spider's sixth leg */
		public ModelRenderer spiderLeg6;

		/** Spider's seventh leg */
		public ModelRenderer spiderLeg7;

		/** Spider's eight leg */
		public ModelRenderer spiderLeg8;

		public ModelSpider()
		{
			float f = 0.0F;
			int i = 15;
			this.spiderHead = new ModelRenderer(this, 32, 4, ModelPart.Head);
			this.spiderHead.addBox(-4.0F, -4.0F, -8.0F, 8, 8, 8, f, "Head");
			this.spiderHead.setRotationPoint(0.0F, (float)i, -3.0F);
			this.spiderNeck = new ModelRenderer(this, 0, 0, ModelPart.Head);
			this.spiderNeck.addBox(-3.0F, -3.0F, -3.0F, 6, 6, 6, f, "Neck");
			this.spiderNeck.setRotationPoint(0.0F, (float)i, 0.0F);
			this.spiderBody = new ModelRenderer(this, 0, 12, ModelPart.Chest);
			this.spiderBody.addBox(-5.0F, -4.0F, -6.0F, 10, 8, 12, f, "Body");
			this.spiderBody.setRotationPoint(0.0F, (float)i, 9.0F);
			this.spiderLeg1 = new ModelRenderer(this, 18, 0);
			this.spiderLeg1.addBox(-15.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 1");
			this.spiderLeg1.setRotationPoint(-4.0F, (float)i, 2.0F);
			this.spiderLeg2 = new ModelRenderer(this, 18, 0);
			this.spiderLeg2.addBox(-1.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 2");
			this.spiderLeg2.setRotationPoint(4.0F, (float)i, 2.0F);
			this.spiderLeg3 = new ModelRenderer(this, 18, 0);
			this.spiderLeg3.addBox(-15.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 3");
			this.spiderLeg3.setRotationPoint(-4.0F, (float)i, 1.0F);
			this.spiderLeg4 = new ModelRenderer(this, 18, 0);
			this.spiderLeg4.addBox(-1.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 4");
			this.spiderLeg4.setRotationPoint(4.0F, (float)i, 1.0F);
			this.spiderLeg5 = new ModelRenderer(this, 18, 0);
			this.spiderLeg5.addBox(-15.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 5");
			this.spiderLeg5.setRotationPoint(-4.0F, (float)i, 0.0F);
			this.spiderLeg6 = new ModelRenderer(this, 18, 0);
			this.spiderLeg6.addBox(-1.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 6");
			this.spiderLeg6.setRotationPoint(4.0F, (float)i, 0.0F);
			this.spiderLeg7 = new ModelRenderer(this, 18, 0);
			this.spiderLeg7.addBox(-15.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 7");
			this.spiderLeg7.setRotationPoint(-4.0F, (float)i, -1.0F);
			this.spiderLeg8 = new ModelRenderer(this, 18, 0);
			this.spiderLeg8.addBox(-1.0F, -1.0F, -1.0F, 16, 2, 2, f, "Leg 8");
			this.spiderLeg8.setRotationPoint(4.0F, (float)i, -1.0F);
		}

#if RENDER
		/**
		 * Sets the models various rotation angles then renders the model.
		 */
		public void render(Entity entityIn, float p_78088_2_, float p_78088_3_, float p_78088_4_, float p_78088_5_, float p_78088_6_, float scale)
		{
			this.setRotationAngles(p_78088_2_, p_78088_3_, p_78088_4_, p_78088_5_, p_78088_6_, scale, entityIn);
			this.spiderHead.render(scale);
			this.spiderNeck.render(scale);
			this.spiderBody.render(scale);
			this.spiderLeg1.render(scale);
			this.spiderLeg2.render(scale);
			this.spiderLeg3.render(scale);
			this.spiderLeg4.render(scale);
			this.spiderLeg5.render(scale);
			this.spiderLeg6.render(scale);
			this.spiderLeg7.render(scale);
			this.spiderLeg8.render(scale);
		}
#endif

		/**
		 * Sets the model's various rotation angles. For bipeds, par1 and par2 are used for animating the movement of arms
		 * and legs, where par1 represents the time(so that arms and legs swing back and forth) and par2 represents how
		 * "far" arms and legs can swing at most.
		 */
		public void setRotationAngles(float limbSwing, float limbSwingAmount, float ageInTicks, float netHeadYaw, float headPitch, float scaleFactor, Entity entityIn)
		{
			this.spiderHead.rotateAngleY = netHeadYaw * 0.017453292F;
			this.spiderHead.rotateAngleX = headPitch * 0.017453292F;
			float f = ((float)Math.PI / 4F);
			this.spiderLeg1.rotateAngleZ = -f;
			this.spiderLeg2.rotateAngleZ = f;
			this.spiderLeg3.rotateAngleZ = -f * 0.74F;
			this.spiderLeg4.rotateAngleZ = f * 0.74F;
			this.spiderLeg5.rotateAngleZ = -f * 0.74F;
			this.spiderLeg6.rotateAngleZ = f * 0.74F;
			this.spiderLeg7.rotateAngleZ = -f;
			this.spiderLeg8.rotateAngleZ = f;
			float f1 = -0.0F;
			float f2 = 0.3926991F;
			this.spiderLeg1.rotateAngleY = f2 * 2.0F + f1;
			this.spiderLeg2.rotateAngleY = -f2 * 2.0F - f1;
			this.spiderLeg3.rotateAngleY = f2 * 1.0F + f1;
			this.spiderLeg4.rotateAngleY = -f2 * 1.0F - f1;
			this.spiderLeg5.rotateAngleY = -f2 * 1.0F + f1;
			this.spiderLeg6.rotateAngleY = f2 * 1.0F - f1;
			this.spiderLeg7.rotateAngleY = -f2 * 2.0F + f1;
			this.spiderLeg8.rotateAngleY = f2 * 2.0F - f1;
			float f3 = -(MathHelper.cos(limbSwing * 0.6662F * 2.0F + 0.0F) * 0.4F) * limbSwingAmount;
			float f4 = -(MathHelper.cos(limbSwing * 0.6662F * 2.0F + (float)Math.PI) * 0.4F) * limbSwingAmount;
			float f5 = -(MathHelper.cos(limbSwing * 0.6662F * 2.0F + ((float)Math.PI / 2F)) * 0.4F) * limbSwingAmount;
			float f6 = -(MathHelper.cos(limbSwing * 0.6662F * 2.0F + ((float)Math.PI * 3F / 2F)) * 0.4F) * limbSwingAmount;
			float f7 = Math.abs(MathHelper.sin(limbSwing * 0.6662F + 0.0F) * 0.4F) * limbSwingAmount;
			float f8 = Math.abs(MathHelper.sin(limbSwing * 0.6662F + (float)Math.PI) * 0.4F) * limbSwingAmount;
			float f9 = Math.abs(MathHelper.sin(limbSwing * 0.6662F + ((float)Math.PI / 2F)) * 0.4F) * limbSwingAmount;
			float f10 = Math.abs(MathHelper.sin(limbSwing * 0.6662F + ((float)Math.PI * 3F / 2F)) * 0.4F) * limbSwingAmount;
			this.spiderLeg1.rotateAngleY += f3;
			this.spiderLeg2.rotateAngleY += -f3;
			this.spiderLeg3.rotateAngleY += f4;
			this.spiderLeg4.rotateAngleY += -f4;
			this.spiderLeg5.rotateAngleY += f5;
			this.spiderLeg6.rotateAngleY += -f5;
			this.spiderLeg7.rotateAngleY += f6;
			this.spiderLeg8.rotateAngleY += -f6;
			this.spiderLeg1.rotateAngleZ += f7;
			this.spiderLeg2.rotateAngleZ += -f7;
			this.spiderLeg3.rotateAngleZ += f8;
			this.spiderLeg4.rotateAngleZ += -f8;
			this.spiderLeg5.rotateAngleZ += f9;
			this.spiderLeg6.rotateAngleZ += -f9;
			this.spiderLeg7.rotateAngleZ += f10;
			this.spiderLeg8.rotateAngleZ += -f10;
		}
	}
}
#endif