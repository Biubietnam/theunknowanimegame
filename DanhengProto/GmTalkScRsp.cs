using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200086D RID: 2157
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GmTalkScRsp : IMessage<GmTalkScRsp>, IMessage, IEquatable<GmTalkScRsp>, IDeepCloneable<GmTalkScRsp>, IBufferMessage
	{
		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06005FD8 RID: 24536 RVA: 0x000FD64C File Offset: 0x000FB84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmTalkScRsp> Parser
		{
			get
			{
				return GmTalkScRsp._parser;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06005FD9 RID: 24537 RVA: 0x000FD653 File Offset: 0x000FB853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GmTalkScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06005FDA RID: 24538 RVA: 0x000FD665 File Offset: 0x000FB865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmTalkScRsp.Descriptor;
			}
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x000FD66C File Offset: 0x000FB86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkScRsp()
		{
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x000FD67F File Offset: 0x000FB87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkScRsp(GmTalkScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.aIOCOLNJLGE_ = other.aIOCOLNJLGE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x000FD6B0 File Offset: 0x000FB8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkScRsp Clone()
		{
			return new GmTalkScRsp(this);
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06005FDE RID: 24542 RVA: 0x000FD6B8 File Offset: 0x000FB8B8
		// (set) Token: 0x06005FDF RID: 24543 RVA: 0x000FD6C0 File Offset: 0x000FB8C0
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06005FE0 RID: 24544 RVA: 0x000FD6C9 File Offset: 0x000FB8C9
		// (set) Token: 0x06005FE1 RID: 24545 RVA: 0x000FD6D1 File Offset: 0x000FB8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AIOCOLNJLGE
		{
			get
			{
				return this.aIOCOLNJLGE_;
			}
			set
			{
				this.aIOCOLNJLGE_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x000FD6E4 File Offset: 0x000FB8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmTalkScRsp);
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x000FD6F4 File Offset: 0x000FB8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmTalkScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && !(this.AIOCOLNJLGE != other.AIOCOLNJLGE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x000FD744 File Offset: 0x000FB944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AIOCOLNJLGE.Length != 0)
			{
				num ^= this.AIOCOLNJLGE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x000FD79E File Offset: 0x000FB99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x000FD7A6 File Offset: 0x000FB9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x000FD7B0 File Offset: 0x000FB9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AIOCOLNJLGE.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.AIOCOLNJLGE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x000FD810 File Offset: 0x000FBA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AIOCOLNJLGE.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AIOCOLNJLGE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x000FD86C File Offset: 0x000FBA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmTalkScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AIOCOLNJLGE.Length != 0)
			{
				this.AIOCOLNJLGE = other.AIOCOLNJLGE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x000FD8C1 File Offset: 0x000FBAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x000FD8CC File Offset: 0x000FBACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AIOCOLNJLGE = input.ReadString();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024D8 RID: 9432
		private static readonly MessageParser<GmTalkScRsp> _parser = new MessageParser<GmTalkScRsp>(() => new GmTalkScRsp());

		// Token: 0x040024D9 RID: 9433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024DA RID: 9434
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040024DB RID: 9435
		private uint retcode_;

		// Token: 0x040024DC RID: 9436
		public const int AIOCOLNJLGEFieldNumber = 14;

		// Token: 0x040024DD RID: 9437
		private string aIOCOLNJLGE_ = "";
	}
}
