using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200141F RID: 5151
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameActivateBulletCsReq : IMessage<WolfBroGameActivateBulletCsReq>, IMessage, IEquatable<WolfBroGameActivateBulletCsReq>, IDeepCloneable<WolfBroGameActivateBulletCsReq>, IBufferMessage
	{
		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x0600E5CC RID: 58828 RVA: 0x00262E61 File Offset: 0x00261061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameActivateBulletCsReq> Parser
		{
			get
			{
				return WolfBroGameActivateBulletCsReq._parser;
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x00262E68 File Offset: 0x00261068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameActivateBulletCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x00262E7A File Offset: 0x0026107A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameActivateBulletCsReq.Descriptor;
			}
		}

		// Token: 0x0600E5CF RID: 58831 RVA: 0x00262E81 File Offset: 0x00261081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameActivateBulletCsReq()
		{
		}

		// Token: 0x0600E5D0 RID: 58832 RVA: 0x00262E89 File Offset: 0x00261089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameActivateBulletCsReq(WolfBroGameActivateBulletCsReq other) : this()
		{
			this.configId_ = other.configId_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5D1 RID: 58833 RVA: 0x00262EBA File Offset: 0x002610BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameActivateBulletCsReq Clone()
		{
			return new WolfBroGameActivateBulletCsReq(this);
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x00262EC2 File Offset: 0x002610C2
		// (set) Token: 0x0600E5D3 RID: 58835 RVA: 0x00262ECA File Offset: 0x002610CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x00262ED3 File Offset: 0x002610D3
		// (set) Token: 0x0600E5D5 RID: 58837 RVA: 0x00262EDB File Offset: 0x002610DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600E5D6 RID: 58838 RVA: 0x00262EE4 File Offset: 0x002610E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameActivateBulletCsReq);
		}

		// Token: 0x0600E5D7 RID: 58839 RVA: 0x00262EF2 File Offset: 0x002610F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameActivateBulletCsReq other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5D8 RID: 58840 RVA: 0x00262F30 File Offset: 0x00261130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0U)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5D9 RID: 58841 RVA: 0x00262F88 File Offset: 0x00261188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E5DA RID: 58842 RVA: 0x00262F90 File Offset: 0x00261190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5DB RID: 58843 RVA: 0x00262F9C File Offset: 0x0026119C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GroupId);
			}
			if (this.ConfigId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5DC RID: 58844 RVA: 0x00262FF8 File Offset: 0x002611F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ConfigId);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x00263050 File Offset: 0x00261250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameActivateBulletCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0U)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x002630A0 File Offset: 0x002612A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x002630AC File Offset: 0x002612AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConfigId = input.ReadUInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005B3E RID: 23358
		private static readonly MessageParser<WolfBroGameActivateBulletCsReq> _parser = new MessageParser<WolfBroGameActivateBulletCsReq>(() => new WolfBroGameActivateBulletCsReq());

		// Token: 0x04005B3F RID: 23359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B40 RID: 23360
		public const int ConfigIdFieldNumber = 5;

		// Token: 0x04005B41 RID: 23361
		private uint configId_;

		// Token: 0x04005B42 RID: 23362
		public const int GroupIdFieldNumber = 4;

		// Token: 0x04005B43 RID: 23363
		private uint groupId_;
	}
}
