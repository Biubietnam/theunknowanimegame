using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D7 RID: 727
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientDownloadDataScNotify : IMessage<ClientDownloadDataScNotify>, IMessage, IEquatable<ClientDownloadDataScNotify>, IDeepCloneable<ClientDownloadDataScNotify>, IBufferMessage
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0005C195 File Offset: 0x0005A395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientDownloadDataScNotify> Parser
		{
			get
			{
				return ClientDownloadDataScNotify._parser;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0005C19C File Offset: 0x0005A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientDownloadDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0005C1AE File Offset: 0x0005A3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientDownloadDataScNotify.Descriptor;
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0005C1B5 File Offset: 0x0005A3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadDataScNotify()
		{
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0005C1BD File Offset: 0x0005A3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadDataScNotify(ClientDownloadDataScNotify other) : this()
		{
			this.downloadData_ = ((other.downloadData_ != null) ? other.downloadData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0005C1F2 File Offset: 0x0005A3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadDataScNotify Clone()
		{
			return new ClientDownloadDataScNotify(this);
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0005C1FA File Offset: 0x0005A3FA
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x0005C202 File Offset: 0x0005A402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData DownloadData
		{
			get
			{
				return this.downloadData_;
			}
			set
			{
				this.downloadData_ = value;
			}
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0005C20B File Offset: 0x0005A40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientDownloadDataScNotify);
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0005C219 File Offset: 0x0005A419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientDownloadDataScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.DownloadData, other.DownloadData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0005C24C File Offset: 0x0005A44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.downloadData_ != null)
			{
				num ^= this.DownloadData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0005C288 File Offset: 0x0005A488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0005C290 File Offset: 0x0005A490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0005C299 File Offset: 0x0005A499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.downloadData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DownloadData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0005C2CC File Offset: 0x0005A4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.downloadData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DownloadData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0005C30C File Offset: 0x0005A50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientDownloadDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.downloadData_ != null)
			{
				if (this.downloadData_ == null)
				{
					this.DownloadData = new ClientDownloadData();
				}
				this.DownloadData.MergeFrom(other.DownloadData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0005C360 File Offset: 0x0005A560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x0005C36C File Offset: 0x0005A56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.downloadData_ == null)
					{
						this.DownloadData = new ClientDownloadData();
					}
					input.ReadMessage(this.DownloadData);
				}
			}
		}

		// Token: 0x04000D62 RID: 3426
		private static readonly MessageParser<ClientDownloadDataScNotify> _parser = new MessageParser<ClientDownloadDataScNotify>(() => new ClientDownloadDataScNotify());

		// Token: 0x04000D63 RID: 3427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D64 RID: 3428
		public const int DownloadDataFieldNumber = 7;

		// Token: 0x04000D65 RID: 3429
		private ClientDownloadData downloadData_;
	}
}
