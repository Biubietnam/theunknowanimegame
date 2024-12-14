using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000311 RID: 785
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CommonRogueComponentUpdateScNotify : IMessage<CommonRogueComponentUpdateScNotify>, IMessage, IEquatable<CommonRogueComponentUpdateScNotify>, IDeepCloneable<CommonRogueComponentUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x0006400F File Offset: 0x0006220F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CommonRogueComponentUpdateScNotify> Parser
		{
			get
			{
				return CommonRogueComponentUpdateScNotify._parser;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x00064016 File Offset: 0x00062216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CommonRogueComponentUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x00064028 File Offset: 0x00062228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonRogueComponentUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0006402F File Offset: 0x0006222F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueComponentUpdateScNotify()
		{
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00064038 File Offset: 0x00062238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueComponentUpdateScNotify(CommonRogueComponentUpdateScNotify other) : this()
		{
			this.rogueMagicBattleConst_ = other.rogueMagicBattleConst_;
			this.iHKHNEGBELE_ = other.iHKHNEGBELE_;
			this.aOPOAONIIAM_ = ((other.aOPOAONIIAM_ != null) ? other.aOPOAONIIAM_.Clone() : null);
			this.rogueSubMode_ = other.rogueSubMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0006409C File Offset: 0x0006229C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonRogueComponentUpdateScNotify Clone()
		{
			return new CommonRogueComponentUpdateScNotify(this);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000640A4 File Offset: 0x000622A4
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x000640AC File Offset: 0x000622AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueMagicBattleConst
		{
			get
			{
				return this.rogueMagicBattleConst_;
			}
			set
			{
				this.rogueMagicBattleConst_ = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000640B5 File Offset: 0x000622B5
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x000640BD File Offset: 0x000622BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IHKHNEGBELE
		{
			get
			{
				return this.iHKHNEGBELE_;
			}
			set
			{
				this.iHKHNEGBELE_ = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000640C6 File Offset: 0x000622C6
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x000640CE File Offset: 0x000622CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGameInfo AOPOAONIIAM
		{
			get
			{
				return this.aOPOAONIIAM_;
			}
			set
			{
				this.aOPOAONIIAM_ = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000640D7 File Offset: 0x000622D7
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x000640DF File Offset: 0x000622DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueSubMode
		{
			get
			{
				return this.rogueSubMode_;
			}
			set
			{
				this.rogueSubMode_ = value;
			}
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x000640E8 File Offset: 0x000622E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonRogueComponentUpdateScNotify);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x000640F8 File Offset: 0x000622F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonRogueComponentUpdateScNotify other)
		{
			return other != null && (other == this || (this.RogueMagicBattleConst == other.RogueMagicBattleConst && this.IHKHNEGBELE == other.IHKHNEGBELE && object.Equals(this.AOPOAONIIAM, other.AOPOAONIIAM) && this.RogueSubMode == other.RogueSubMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00064168 File Offset: 0x00062368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RogueMagicBattleConst != 0U)
			{
				num ^= this.RogueMagicBattleConst.GetHashCode();
			}
			if (this.IHKHNEGBELE != 0U)
			{
				num ^= this.IHKHNEGBELE.GetHashCode();
			}
			if (this.aOPOAONIIAM_ != null)
			{
				num ^= this.AOPOAONIIAM.GetHashCode();
			}
			if (this.RogueSubMode != 0U)
			{
				num ^= this.RogueSubMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x000641EF File Offset: 0x000623EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x000641F7 File Offset: 0x000623F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00064200 File Offset: 0x00062400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aOPOAONIIAM_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AOPOAONIIAM);
			}
			if (this.RogueMagicBattleConst != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.RogueMagicBattleConst);
			}
			if (this.RogueSubMode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RogueSubMode);
			}
			if (this.IHKHNEGBELE != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.IHKHNEGBELE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00064294 File Offset: 0x00062494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RogueMagicBattleConst != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueMagicBattleConst);
			}
			if (this.IHKHNEGBELE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IHKHNEGBELE);
			}
			if (this.aOPOAONIIAM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AOPOAONIIAM);
			}
			if (this.RogueSubMode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueSubMode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0006431C File Offset: 0x0006251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonRogueComponentUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RogueMagicBattleConst != 0U)
			{
				this.RogueMagicBattleConst = other.RogueMagicBattleConst;
			}
			if (other.IHKHNEGBELE != 0U)
			{
				this.IHKHNEGBELE = other.IHKHNEGBELE;
			}
			if (other.aOPOAONIIAM_ != null)
			{
				if (this.aOPOAONIIAM_ == null)
				{
					this.AOPOAONIIAM = new RogueGameInfo();
				}
				this.AOPOAONIIAM.MergeFrom(other.AOPOAONIIAM);
			}
			if (other.RogueSubMode != 0U)
			{
				this.RogueSubMode = other.RogueSubMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000643AC File Offset: 0x000625AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000643B8 File Offset: 0x000625B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 26U)
					{
						if (this.aOPOAONIIAM_ == null)
						{
							this.AOPOAONIIAM = new RogueGameInfo();
						}
						input.ReadMessage(this.AOPOAONIIAM);
						continue;
					}
					if (num == 40U)
					{
						this.RogueMagicBattleConst = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.RogueSubMode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.IHKHNEGBELE = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000E79 RID: 3705
		private static readonly MessageParser<CommonRogueComponentUpdateScNotify> _parser = new MessageParser<CommonRogueComponentUpdateScNotify>(() => new CommonRogueComponentUpdateScNotify());

		// Token: 0x04000E7A RID: 3706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E7B RID: 3707
		public const int RogueMagicBattleConstFieldNumber = 5;

		// Token: 0x04000E7C RID: 3708
		private uint rogueMagicBattleConst_;

		// Token: 0x04000E7D RID: 3709
		public const int IHKHNEGBELEFieldNumber = 13;

		// Token: 0x04000E7E RID: 3710
		private uint iHKHNEGBELE_;

		// Token: 0x04000E7F RID: 3711
		public const int AOPOAONIIAMFieldNumber = 3;

		// Token: 0x04000E80 RID: 3712
		private RogueGameInfo aOPOAONIIAM_;

		// Token: 0x04000E81 RID: 3713
		public const int RogueSubModeFieldNumber = 7;

		// Token: 0x04000E82 RID: 3714
		private uint rogueSubMode_;
	}
}
