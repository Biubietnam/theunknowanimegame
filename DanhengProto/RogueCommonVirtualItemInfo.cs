using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E67 RID: 3687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonVirtualItemInfo : IMessage<RogueCommonVirtualItemInfo>, IMessage, IEquatable<RogueCommonVirtualItemInfo>, IDeepCloneable<RogueCommonVirtualItemInfo>, IBufferMessage
	{
		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x001B9D61 File Offset: 0x001B7F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonVirtualItemInfo> Parser
		{
			get
			{
				return RogueCommonVirtualItemInfo._parser;
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0600A46E RID: 42094 RVA: 0x001B9D68 File Offset: 0x001B7F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonVirtualItemInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600A46F RID: 42095 RVA: 0x001B9D7A File Offset: 0x001B7F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonVirtualItemInfo.Descriptor;
			}
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x001B9D81 File Offset: 0x001B7F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonVirtualItemInfo()
		{
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x001B9D89 File Offset: 0x001B7F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonVirtualItemInfo(RogueCommonVirtualItemInfo other) : this()
		{
			this.virtualItemNum_ = other.virtualItemNum_;
			this.virtualItemId_ = other.virtualItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x001B9DBA File Offset: 0x001B7FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonVirtualItemInfo Clone()
		{
			return new RogueCommonVirtualItemInfo(this);
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600A473 RID: 42099 RVA: 0x001B9DC2 File Offset: 0x001B7FC2
		// (set) Token: 0x0600A474 RID: 42100 RVA: 0x001B9DCA File Offset: 0x001B7FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint VirtualItemNum
		{
			get
			{
				return this.virtualItemNum_;
			}
			set
			{
				this.virtualItemNum_ = value;
			}
		}

		// Token: 0x17002E6B RID: 11883
		// (get) Token: 0x0600A475 RID: 42101 RVA: 0x001B9DD3 File Offset: 0x001B7FD3
		// (set) Token: 0x0600A476 RID: 42102 RVA: 0x001B9DDB File Offset: 0x001B7FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint VirtualItemId
		{
			get
			{
				return this.virtualItemId_;
			}
			set
			{
				this.virtualItemId_ = value;
			}
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x001B9DE4 File Offset: 0x001B7FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonVirtualItemInfo);
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x001B9DF2 File Offset: 0x001B7FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonVirtualItemInfo other)
		{
			return other != null && (other == this || (this.VirtualItemNum == other.VirtualItemNum && this.VirtualItemId == other.VirtualItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x001B9E30 File Offset: 0x001B8030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VirtualItemNum != 0U)
			{
				num ^= this.VirtualItemNum.GetHashCode();
			}
			if (this.VirtualItemId != 0U)
			{
				num ^= this.VirtualItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x001B9E88 File Offset: 0x001B8088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x001B9E90 File Offset: 0x001B8090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x001B9E9C File Offset: 0x001B809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VirtualItemNum != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.VirtualItemNum);
			}
			if (this.VirtualItemId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.VirtualItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x001B9EF8 File Offset: 0x001B80F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VirtualItemNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VirtualItemNum);
			}
			if (this.VirtualItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.VirtualItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x001B9F50 File Offset: 0x001B8150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonVirtualItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VirtualItemNum != 0U)
			{
				this.VirtualItemNum = other.VirtualItemNum;
			}
			if (other.VirtualItemId != 0U)
			{
				this.VirtualItemId = other.VirtualItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x001B9FA0 File Offset: 0x001B81A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x001B9FAC File Offset: 0x001B81AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.VirtualItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.VirtualItemNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400432F RID: 17199
		private static readonly MessageParser<RogueCommonVirtualItemInfo> _parser = new MessageParser<RogueCommonVirtualItemInfo>(() => new RogueCommonVirtualItemInfo());

		// Token: 0x04004330 RID: 17200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004331 RID: 17201
		public const int VirtualItemNumFieldNumber = 5;

		// Token: 0x04004332 RID: 17202
		private uint virtualItemNum_;

		// Token: 0x04004333 RID: 17203
		public const int VirtualItemIdFieldNumber = 9;

		// Token: 0x04004334 RID: 17204
		private uint virtualItemId_;
	}
}
