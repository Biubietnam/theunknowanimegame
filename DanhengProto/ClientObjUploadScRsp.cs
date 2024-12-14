using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002E3 RID: 739
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientObjUploadScRsp : IMessage<ClientObjUploadScRsp>, IMessage, IEquatable<ClientObjUploadScRsp>, IDeepCloneable<ClientObjUploadScRsp>, IBufferMessage
	{
		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0005DC0D File Offset: 0x0005BE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientObjUploadScRsp> Parser
		{
			get
			{
				return ClientObjUploadScRsp._parser;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x0005DC14 File Offset: 0x0005BE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientObjUploadScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0005DC26 File Offset: 0x0005BE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientObjUploadScRsp.Descriptor;
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0005DC2D File Offset: 0x0005BE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjUploadScRsp()
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0005DC38 File Offset: 0x0005BE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjUploadScRsp(ClientObjUploadScRsp other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0005DC84 File Offset: 0x0005BE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjUploadScRsp Clone()
		{
			return new ClientObjUploadScRsp(this);
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0005DC8C File Offset: 0x0005BE8C
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x0005DC94 File Offset: 0x0005BE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadData Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x0005DC9D File Offset: 0x0005BE9D
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x0005DCA5 File Offset: 0x0005BEA5
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

		// Token: 0x06002102 RID: 8450 RVA: 0x0005DCAE File Offset: 0x0005BEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientObjUploadScRsp);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0005DCBC File Offset: 0x0005BEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientObjUploadScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0005DD0C File Offset: 0x0005BF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
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

		// Token: 0x06002105 RID: 8453 RVA: 0x0005DD61 File Offset: 0x0005BF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x0005DD69 File Offset: 0x0005BF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0005DD74 File Offset: 0x0005BF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.data_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0005DDD0 File Offset: 0x0005BFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
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

		// Token: 0x06002109 RID: 8457 RVA: 0x0005DE28 File Offset: 0x0005C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientObjUploadScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new ClientObjDownloadData();
				}
				this.Data.MergeFrom(other.Data);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0005DE90 File Offset: 0x0005C090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0005DE9C File Offset: 0x0005C09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.data_ == null)
						{
							this.Data = new ClientObjDownloadData();
						}
						input.ReadMessage(this.Data);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D9B RID: 3483
		private static readonly MessageParser<ClientObjUploadScRsp> _parser = new MessageParser<ClientObjUploadScRsp>(() => new ClientObjUploadScRsp());

		// Token: 0x04000D9C RID: 3484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D9D RID: 3485
		public const int DataFieldNumber = 8;

		// Token: 0x04000D9E RID: 3486
		private ClientObjDownloadData data_;

		// Token: 0x04000D9F RID: 3487
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000DA0 RID: 3488
		private uint retcode_;
	}
}
