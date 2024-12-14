using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF9 RID: 3833
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicReviveAvatarScRsp : IMessage<RogueMagicReviveAvatarScRsp>, IMessage, IEquatable<RogueMagicReviveAvatarScRsp>, IDeepCloneable<RogueMagicReviveAvatarScRsp>, IBufferMessage
	{
		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0600AB32 RID: 43826 RVA: 0x001CD2C7 File Offset: 0x001CB4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicReviveAvatarScRsp> Parser
		{
			get
			{
				return RogueMagicReviveAvatarScRsp._parser;
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x001CD2CE File Offset: 0x001CB4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicReviveAvatarScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600AB34 RID: 43828 RVA: 0x001CD2E0 File Offset: 0x001CB4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicReviveAvatarScRsp.Descriptor;
			}
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x001CD2E7 File Offset: 0x001CB4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveAvatarScRsp()
		{
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x001CD2F0 File Offset: 0x001CB4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveAvatarScRsp(RogueMagicReviveAvatarScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueReviveCost_ = ((other.rogueReviveCost_ != null) ? other.rogueReviveCost_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x001CD33C File Offset: 0x001CB53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicReviveAvatarScRsp Clone()
		{
			return new RogueMagicReviveAvatarScRsp(this);
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600AB38 RID: 43832 RVA: 0x001CD344 File Offset: 0x001CB544
		// (set) Token: 0x0600AB39 RID: 43833 RVA: 0x001CD34C File Offset: 0x001CB54C
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

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0600AB3A RID: 43834 RVA: 0x001CD355 File Offset: 0x001CB555
		// (set) Token: 0x0600AB3B RID: 43835 RVA: 0x001CD35D File Offset: 0x001CB55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData RogueReviveCost
		{
			get
			{
				return this.rogueReviveCost_;
			}
			set
			{
				this.rogueReviveCost_ = value;
			}
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x001CD366 File Offset: 0x001CB566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicReviveAvatarScRsp);
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x001CD374 File Offset: 0x001CB574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicReviveAvatarScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueReviveCost, other.RogueReviveCost) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x001CD3C4 File Offset: 0x001CB5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueReviveCost_ != null)
			{
				num ^= this.RogueReviveCost.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB3F RID: 43839 RVA: 0x001CD419 File Offset: 0x001CB619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x001CD421 File Offset: 0x001CB621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x001CD42C File Offset: 0x001CB62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueReviveCost_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueReviveCost);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x001CD488 File Offset: 0x001CB688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueReviveCost_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueReviveCost);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x001CD4E0 File Offset: 0x001CB6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicReviveAvatarScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueReviveCost_ != null)
			{
				if (this.rogueReviveCost_ == null)
				{
					this.RogueReviveCost = new ItemCostData();
				}
				this.RogueReviveCost.MergeFrom(other.RogueReviveCost);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x001CD548 File Offset: 0x001CB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x001CD554 File Offset: 0x001CB754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueReviveCost_ == null)
					{
						this.RogueReviveCost = new ItemCostData();
					}
					input.ReadMessage(this.RogueReviveCost);
				}
			}
		}

		// Token: 0x040045E0 RID: 17888
		private static readonly MessageParser<RogueMagicReviveAvatarScRsp> _parser = new MessageParser<RogueMagicReviveAvatarScRsp>(() => new RogueMagicReviveAvatarScRsp());

		// Token: 0x040045E1 RID: 17889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045E2 RID: 17890
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040045E3 RID: 17891
		private uint retcode_;

		// Token: 0x040045E4 RID: 17892
		public const int RogueReviveCostFieldNumber = 14;

		// Token: 0x040045E5 RID: 17893
		private ItemCostData rogueReviveCost_;
	}
}
