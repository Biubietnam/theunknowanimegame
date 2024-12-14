using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D5 RID: 725
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientDownloadData : IMessage<ClientDownloadData>, IMessage, IEquatable<ClientDownloadData>, IDeepCloneable<ClientDownloadData>, IBufferMessage
	{
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0005BD88 File Offset: 0x00059F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClientDownloadData> Parser
		{
			get
			{
				return ClientDownloadData._parser;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0005BD8F File Offset: 0x00059F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientDownloadDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x0005BDA1 File Offset: 0x00059FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientDownloadData.Descriptor;
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0005BDA8 File Offset: 0x00059FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData()
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0005BDBB File Offset: 0x00059FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData(ClientDownloadData other) : this()
		{
			this.version_ = other.version_;
			this.time_ = other.time_;
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0005BDF8 File Offset: 0x00059FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData Clone()
		{
			return new ClientDownloadData(this);
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x0005BE00 File Offset: 0x0005A000
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x0005BE08 File Offset: 0x0005A008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0005BE11 File Offset: 0x0005A011
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x0005BE19 File Offset: 0x0005A019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Time
		{
			get
			{
				return this.time_;
			}
			set
			{
				this.time_ = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x0005BE22 File Offset: 0x0005A022
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x0005BE2A File Offset: 0x0005A02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0005BE3D File Offset: 0x0005A03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientDownloadData);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0005BE4C File Offset: 0x0005A04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientDownloadData other)
		{
			return other != null && (other == this || (this.Version == other.Version && this.Time == other.Time && !(this.Data != other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0005BEAC File Offset: 0x0005A0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Version != 0U)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this.Time != 0L)
			{
				num ^= this.Time.GetHashCode();
			}
			if (this.Data.Length != 0)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0005BF1F File Offset: 0x0005A11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0005BF27 File Offset: 0x0005A127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0005BF30 File Offset: 0x0005A130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Version != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Version);
			}
			if (this.Time != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Time);
			}
			if (this.Data.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0005BFAC File Offset: 0x0005A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Version != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Version);
			}
			if (this.Time != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Time);
			}
			if (this.Data.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0005C020 File Offset: 0x0005A220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientDownloadData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Version != 0U)
			{
				this.Version = other.Version;
			}
			if (other.Time != 0L)
			{
				this.Time = other.Time;
			}
			if (other.Data.Length != 0)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0005C089 File Offset: 0x0005A289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0005C094 File Offset: 0x0005A294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Data = input.ReadBytes();
						}
					}
					else
					{
						this.Time = input.ReadInt64();
					}
				}
				else
				{
					this.Version = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D59 RID: 3417
		private static readonly MessageParser<ClientDownloadData> _parser = new MessageParser<ClientDownloadData>(() => new ClientDownloadData());

		// Token: 0x04000D5A RID: 3418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D5B RID: 3419
		public const int VersionFieldNumber = 1;

		// Token: 0x04000D5C RID: 3420
		private uint version_;

		// Token: 0x04000D5D RID: 3421
		public const int TimeFieldNumber = 2;

		// Token: 0x04000D5E RID: 3422
		private long time_;

		// Token: 0x04000D5F RID: 3423
		public const int DataFieldNumber = 3;

		// Token: 0x04000D60 RID: 3424
		private ByteString data_ = ByteString.Empty;
	}
}
