using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002DD RID: 733
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientObjDownloadData : IMessage<ClientObjDownloadData>, IMessage, IEquatable<ClientObjDownloadData>, IDeepCloneable<ClientObjDownloadData>, IBufferMessage
	{
		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0005D223 File Offset: 0x0005B423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientObjDownloadData> Parser
		{
			get
			{
				return ClientObjDownloadData._parser;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0005D22A File Offset: 0x0005B42A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientObjDownloadDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0005D23C File Offset: 0x0005B43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientObjDownloadData.Descriptor;
			}
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0005D243 File Offset: 0x0005B443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadData()
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0005D258 File Offset: 0x0005B458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadData(ClientObjDownloadData other) : this()
		{
			this.jPDKEPHLFEN_ = other.jPDKEPHLFEN_;
			this.clientObjDownloadData_ = ((other.clientObjDownloadData_ != null) ? other.clientObjDownloadData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0005D2A4 File Offset: 0x0005B4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadData Clone()
		{
			return new ClientObjDownloadData(this);
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0005D2AC File Offset: 0x0005B4AC
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0005D2B4 File Offset: 0x0005B4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString JPDKEPHLFEN
		{
			get
			{
				return this.jPDKEPHLFEN_;
			}
			set
			{
				this.jPDKEPHLFEN_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0005D2C7 File Offset: 0x0005B4C7
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0005D2CF File Offset: 0x0005B4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData ClientObjDownloadData_
		{
			get
			{
				return this.clientObjDownloadData_;
			}
			set
			{
				this.clientObjDownloadData_ = value;
			}
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0005D2D8 File Offset: 0x0005B4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientObjDownloadData);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0005D2E8 File Offset: 0x0005B4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientObjDownloadData other)
		{
			return other != null && (other == this || (!(this.JPDKEPHLFEN != other.JPDKEPHLFEN) && object.Equals(this.ClientObjDownloadData_, other.ClientObjDownloadData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0005D33C File Offset: 0x0005B53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JPDKEPHLFEN.Length != 0)
			{
				num ^= this.JPDKEPHLFEN.GetHashCode();
			}
			if (this.clientObjDownloadData_ != null)
			{
				num ^= this.ClientObjDownloadData_.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0005D393 File Offset: 0x0005B593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0005D39B File Offset: 0x0005B59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JPDKEPHLFEN.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(this.JPDKEPHLFEN);
			}
			if (this.clientObjDownloadData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ClientObjDownloadData_);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0005D404 File Offset: 0x0005B604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JPDKEPHLFEN.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.JPDKEPHLFEN);
			}
			if (this.clientObjDownloadData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientObjDownloadData_);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0005D460 File Offset: 0x0005B660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientObjDownloadData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JPDKEPHLFEN.Length != 0)
			{
				this.JPDKEPHLFEN = other.JPDKEPHLFEN;
			}
			if (other.clientObjDownloadData_ != null)
			{
				if (this.clientObjDownloadData_ == null)
				{
					this.ClientObjDownloadData_ = new ClientDownloadData();
				}
				this.ClientObjDownloadData_.MergeFrom(other.ClientObjDownloadData_);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x0005D4CD File Offset: 0x0005B6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0005D4D8 File Offset: 0x0005B6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.clientObjDownloadData_ == null)
						{
							this.ClientObjDownloadData_ = new ClientDownloadData();
						}
						input.ReadMessage(this.ClientObjDownloadData_);
					}
				}
				else
				{
					this.JPDKEPHLFEN = input.ReadBytes();
				}
			}
		}

		// Token: 0x04000D88 RID: 3464
		private static readonly MessageParser<ClientObjDownloadData> _parser = new MessageParser<ClientObjDownloadData>(() => new ClientObjDownloadData());

		// Token: 0x04000D89 RID: 3465
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D8A RID: 3466
		public const int JPDKEPHLFENFieldNumber = 1;

		// Token: 0x04000D8B RID: 3467
		private ByteString jPDKEPHLFEN_ = ByteString.Empty;

		// Token: 0x04000D8C RID: 3468
		public const int ClientObjDownloadData_FieldNumber = 2;

		// Token: 0x04000D8D RID: 3469
		private ClientDownloadData clientObjDownloadData_;
	}
}
