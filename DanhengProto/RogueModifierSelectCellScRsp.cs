using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F53 RID: 3923
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueModifierSelectCellScRsp : IMessage<RogueModifierSelectCellScRsp>, IMessage, IEquatable<RogueModifierSelectCellScRsp>, IDeepCloneable<RogueModifierSelectCellScRsp>, IBufferMessage
	{
		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x001D65CF File Offset: 0x001D47CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueModifierSelectCellScRsp> Parser
		{
			get
			{
				return RogueModifierSelectCellScRsp._parser;
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x001D65D6 File Offset: 0x001D47D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueModifierSelectCellScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x001D65E8 File Offset: 0x001D47E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueModifierSelectCellScRsp.Descriptor;
			}
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x001D65EF File Offset: 0x001D47EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSelectCellScRsp()
		{
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x001D65F8 File Offset: 0x001D47F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSelectCellScRsp(RogueModifierSelectCellScRsp other) : this()
		{
			this.dKKJOEJNIAK_ = ((other.dKKJOEJNIAK_ != null) ? other.dKKJOEJNIAK_.Clone() : null);
			this.cellId_ = other.cellId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x001D6650 File Offset: 0x001D4850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueModifierSelectCellScRsp Clone()
		{
			return new RogueModifierSelectCellScRsp(this);
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x001D6658 File Offset: 0x001D4858
		// (set) Token: 0x0600AF00 RID: 44800 RVA: 0x001D6660 File Offset: 0x001D4860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList DKKJOEJNIAK
		{
			get
			{
				return this.dKKJOEJNIAK_;
			}
			set
			{
				this.dKKJOEJNIAK_ = value;
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x001D6669 File Offset: 0x001D4869
		// (set) Token: 0x0600AF02 RID: 44802 RVA: 0x001D6671 File Offset: 0x001D4871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0600AF03 RID: 44803 RVA: 0x001D667A File Offset: 0x001D487A
		// (set) Token: 0x0600AF04 RID: 44804 RVA: 0x001D6682 File Offset: 0x001D4882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x001D668B File Offset: 0x001D488B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueModifierSelectCellScRsp);
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x001D669C File Offset: 0x001D489C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueModifierSelectCellScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.DKKJOEJNIAK, other.DKKJOEJNIAK) && this.CellId == other.CellId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x001D66FC File Offset: 0x001D48FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dKKJOEJNIAK_ != null)
			{
				num ^= this.DKKJOEJNIAK.GetHashCode();
			}
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF08 RID: 44808 RVA: 0x001D676A File Offset: 0x001D496A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x001D6772 File Offset: 0x001D4972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x001D677C File Offset: 0x001D497C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CellId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.dKKJOEJNIAK_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.DKKJOEJNIAK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x001D67F4 File Offset: 0x001D49F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dKKJOEJNIAK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DKKJOEJNIAK);
			}
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF0C RID: 44812 RVA: 0x001D6864 File Offset: 0x001D4A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueModifierSelectCellScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dKKJOEJNIAK_ != null)
			{
				if (this.dKKJOEJNIAK_ == null)
				{
					this.DKKJOEJNIAK = new ItemList();
				}
				this.DKKJOEJNIAK.MergeFrom(other.DKKJOEJNIAK);
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF0D RID: 44813 RVA: 0x001D68E0 File Offset: 0x001D4AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x001D68EC File Offset: 0x001D4AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 88U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.dKKJOEJNIAK_ == null)
							{
								this.DKKJOEJNIAK = new ItemList();
							}
							input.ReadMessage(this.DKKJOEJNIAK);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.CellId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400472F RID: 18223
		private static readonly MessageParser<RogueModifierSelectCellScRsp> _parser = new MessageParser<RogueModifierSelectCellScRsp>(() => new RogueModifierSelectCellScRsp());

		// Token: 0x04004730 RID: 18224
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004731 RID: 18225
		public const int DKKJOEJNIAKFieldNumber = 15;

		// Token: 0x04004732 RID: 18226
		private ItemList dKKJOEJNIAK_;

		// Token: 0x04004733 RID: 18227
		public const int CellIdFieldNumber = 7;

		// Token: 0x04004734 RID: 18228
		private uint cellId_;

		// Token: 0x04004735 RID: 18229
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04004736 RID: 18230
		private uint retcode_;
	}
}
