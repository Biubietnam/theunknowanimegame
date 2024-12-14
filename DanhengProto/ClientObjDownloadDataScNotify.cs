using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002DF RID: 735
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientObjDownloadDataScNotify : IMessage<ClientObjDownloadDataScNotify>, IMessage, IEquatable<ClientObjDownloadDataScNotify>, IDeepCloneable<ClientObjDownloadDataScNotify>, IBufferMessage
	{
		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0005D5D9 File Offset: 0x0005B7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientObjDownloadDataScNotify> Parser
		{
			get
			{
				return ClientObjDownloadDataScNotify._parser;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0005D5E0 File Offset: 0x0005B7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientObjDownloadDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x0005D5F2 File Offset: 0x0005B7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientObjDownloadDataScNotify.Descriptor;
			}
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x0005D5F9 File Offset: 0x0005B7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadDataScNotify()
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0005D601 File Offset: 0x0005B801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadDataScNotify(ClientObjDownloadDataScNotify other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0005D636 File Offset: 0x0005B836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientObjDownloadDataScNotify Clone()
		{
			return new ClientObjDownloadDataScNotify(this);
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0005D63E File Offset: 0x0005B83E
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0005D646 File Offset: 0x0005B846
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

		// Token: 0x060020D4 RID: 8404 RVA: 0x0005D64F File Offset: 0x0005B84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientObjDownloadDataScNotify);
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0005D65D File Offset: 0x0005B85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientObjDownloadDataScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0005D690 File Offset: 0x0005B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0005D6CC File Offset: 0x0005B8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0005D6DD File Offset: 0x0005B8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x0005D710 File Offset: 0x0005B910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0005D750 File Offset: 0x0005B950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientObjDownloadDataScNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x0005D7A4 File Offset: 0x0005B9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x0005D7B0 File Offset: 0x0005B9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
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
		}

		// Token: 0x04000D8F RID: 3471
		private static readonly MessageParser<ClientObjDownloadDataScNotify> _parser = new MessageParser<ClientObjDownloadDataScNotify>(() => new ClientObjDownloadDataScNotify());

		// Token: 0x04000D90 RID: 3472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D91 RID: 3473
		public const int DataFieldNumber = 14;

		// Token: 0x04000D92 RID: 3474
		private ClientObjDownloadData data_;
	}
}
