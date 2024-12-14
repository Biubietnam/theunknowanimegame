using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200096F RID: 2415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JJHOKEMCLGI : IMessage<JJHOKEMCLGI>, IMessage, IEquatable<JJHOKEMCLGI>, IDeepCloneable<JJHOKEMCLGI>, IBufferMessage
	{
		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x0011F6EB File Offset: 0x0011D8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JJHOKEMCLGI> Parser
		{
			get
			{
				return JJHOKEMCLGI._parser;
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x0011F6F2 File Offset: 0x0011D8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JJHOKEMCLGIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x0011F704 File Offset: 0x0011D904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JJHOKEMCLGI.Descriptor;
			}
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x0011F70B File Offset: 0x0011D90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJHOKEMCLGI()
		{
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x0011F714 File Offset: 0x0011D914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJHOKEMCLGI(JJHOKEMCLGI other) : this()
		{
			this.magicItem_ = ((other.magicItem_ != null) ? other.magicItem_.Clone() : null);
			this.iBPPPCMOAFI_ = other.iBPPPCMOAFI_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x0011F77C File Offset: 0x0011D97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJHOKEMCLGI Clone()
		{
			return new JJHOKEMCLGI(this);
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06006BDF RID: 27615 RVA: 0x0011F784 File Offset: 0x0011D984
		// (set) Token: 0x06006BE0 RID: 27616 RVA: 0x0011F78C File Offset: 0x0011D98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter MagicItem
		{
			get
			{
				return this.magicItem_;
			}
			set
			{
				this.magicItem_ = value;
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x0011F795 File Offset: 0x0011D995
		// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x0011F79D File Offset: 0x0011D99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IBPPPCMOAFI
		{
			get
			{
				return this.iBPPPCMOAFI_;
			}
			set
			{
				this.iBPPPCMOAFI_ = value;
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x0011F7A6 File Offset: 0x0011D9A6
		// (set) Token: 0x06006BE4 RID: 27620 RVA: 0x0011F7AE File Offset: 0x0011D9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData CostData
		{
			get
			{
				return this.costData_;
			}
			set
			{
				this.costData_ = value;
			}
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x0011F7B7 File Offset: 0x0011D9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JJHOKEMCLGI);
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x0011F7C8 File Offset: 0x0011D9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JJHOKEMCLGI other)
		{
			return other != null && (other == this || (object.Equals(this.MagicItem, other.MagicItem) && this.IBPPPCMOAFI == other.IBPPPCMOAFI && object.Equals(this.CostData, other.CostData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x0011F82C File Offset: 0x0011DA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.magicItem_ != null)
			{
				num ^= this.MagicItem.GetHashCode();
			}
			if (this.IBPPPCMOAFI)
			{
				num ^= this.IBPPPCMOAFI.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x0011F897 File Offset: 0x0011DA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x0011F89F File Offset: 0x0011DA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x0011F8A8 File Offset: 0x0011DAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.magicItem_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MagicItem);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CostData);
			}
			if (this.IBPPPCMOAFI)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IBPPPCMOAFI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x0011F920 File Offset: 0x0011DB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.magicItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MagicItem);
			}
			if (this.IBPPPCMOAFI)
			{
				num += 2;
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x0011F984 File Offset: 0x0011DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JJHOKEMCLGI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.magicItem_ != null)
			{
				if (this.magicItem_ == null)
				{
					this.MagicItem = new RogueMagicScepter();
				}
				this.MagicItem.MergeFrom(other.MagicItem);
			}
			if (other.IBPPPCMOAFI)
			{
				this.IBPPPCMOAFI = other.IBPPPCMOAFI;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x0011FA18 File Offset: 0x0011DC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BEE RID: 27630 RVA: 0x0011FA24 File Offset: 0x0011DC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 106U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IBPPPCMOAFI = input.ReadBool();
						}
					}
					else
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
					}
				}
				else
				{
					if (this.magicItem_ == null)
					{
						this.MagicItem = new RogueMagicScepter();
					}
					input.ReadMessage(this.MagicItem);
				}
			}
		}

		// Token: 0x04002943 RID: 10563
		private static readonly MessageParser<JJHOKEMCLGI> _parser = new MessageParser<JJHOKEMCLGI>(() => new JJHOKEMCLGI());

		// Token: 0x04002944 RID: 10564
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002945 RID: 10565
		public const int MagicItemFieldNumber = 3;

		// Token: 0x04002946 RID: 10566
		private RogueMagicScepter magicItem_;

		// Token: 0x04002947 RID: 10567
		public const int IBPPPCMOAFIFieldNumber = 14;

		// Token: 0x04002948 RID: 10568
		private bool iBPPPCMOAFI_;

		// Token: 0x04002949 RID: 10569
		public const int CostDataFieldNumber = 13;

		// Token: 0x0400294A RID: 10570
		private ItemCostData costData_;
	}
}
