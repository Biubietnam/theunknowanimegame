using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DAB RID: 3499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicList : IMessage<RelicList>, IMessage, IEquatable<RelicList>, IDeepCloneable<RelicList>, IBufferMessage
	{
		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x001A0AA4 File Offset: 0x0019ECA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicList> Parser
		{
			get
			{
				return RelicList._parser;
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x06009C6D RID: 40045 RVA: 0x001A0AAB File Offset: 0x0019ECAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x06009C6E RID: 40046 RVA: 0x001A0ABD File Offset: 0x0019ECBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicList.Descriptor;
			}
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x001A0AC4 File Offset: 0x0019ECC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicList()
		{
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x001A0ACC File Offset: 0x0019ECCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicList(RelicList other) : this()
		{
			this.setId_ = other.setId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x001A0AFD File Offset: 0x0019ECFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicList Clone()
		{
			return new RelicList(this);
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x06009C72 RID: 40050 RVA: 0x001A0B05 File Offset: 0x0019ED05
		// (set) Token: 0x06009C73 RID: 40051 RVA: 0x001A0B0D File Offset: 0x0019ED0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SetId
		{
			get
			{
				return this.setId_;
			}
			set
			{
				this.setId_ = value;
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x06009C74 RID: 40052 RVA: 0x001A0B16 File Offset: 0x0019ED16
		// (set) Token: 0x06009C75 RID: 40053 RVA: 0x001A0B1E File Offset: 0x0019ED1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x001A0B27 File Offset: 0x0019ED27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicList);
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x001A0B35 File Offset: 0x0019ED35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicList other)
		{
			return other != null && (other == this || (this.SetId == other.SetId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x001A0B74 File Offset: 0x0019ED74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SetId != 0U)
			{
				num ^= this.SetId.GetHashCode();
			}
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C79 RID: 40057 RVA: 0x001A0BCC File Offset: 0x0019EDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x001A0BD4 File Offset: 0x0019EDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x001A0BE0 File Offset: 0x0019EDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SetId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SetId);
			}
			if (this.Type != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x001A0C3C File Offset: 0x0019EE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SetId);
			}
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C7D RID: 40061 RVA: 0x001A0C94 File Offset: 0x0019EE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicList other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SetId != 0U)
			{
				this.SetId = other.SetId;
			}
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C7E RID: 40062 RVA: 0x001A0CE4 File Offset: 0x0019EEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C7F RID: 40063 RVA: 0x001A0CF0 File Offset: 0x0019EEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = input.ReadUInt32();
					}
				}
				else
				{
					this.SetId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003CCC RID: 15564
		private static readonly MessageParser<RelicList> _parser = new MessageParser<RelicList>(() => new RelicList());

		// Token: 0x04003CCD RID: 15565
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CCE RID: 15566
		public const int SetIdFieldNumber = 2;

		// Token: 0x04003CCF RID: 15567
		private uint setId_;

		// Token: 0x04003CD0 RID: 15568
		public const int TypeFieldNumber = 12;

		// Token: 0x04003CD1 RID: 15569
		private uint type_;
	}
}
