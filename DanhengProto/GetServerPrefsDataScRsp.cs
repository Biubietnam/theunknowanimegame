using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007EF RID: 2031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetServerPrefsDataScRsp : IMessage<GetServerPrefsDataScRsp>, IMessage, IEquatable<GetServerPrefsDataScRsp>, IDeepCloneable<GetServerPrefsDataScRsp>, IBufferMessage
	{
		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x000F1809 File Offset: 0x000EFA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetServerPrefsDataScRsp> Parser
		{
			get
			{
				return GetServerPrefsDataScRsp._parser;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x000F1810 File Offset: 0x000EFA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetServerPrefsDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x000F1822 File Offset: 0x000EFA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetServerPrefsDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x000F1829 File Offset: 0x000EFA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetServerPrefsDataScRsp()
		{
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x000F1834 File Offset: 0x000EFA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetServerPrefsDataScRsp(GetServerPrefsDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.serverPrefs_ = ((other.serverPrefs_ != null) ? other.serverPrefs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x000F1880 File Offset: 0x000EFA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetServerPrefsDataScRsp Clone()
		{
			return new GetServerPrefsDataScRsp(this);
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06005A9E RID: 23198 RVA: 0x000F1888 File Offset: 0x000EFA88
		// (set) Token: 0x06005A9F RID: 23199 RVA: 0x000F1890 File Offset: 0x000EFA90
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

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x000F1899 File Offset: 0x000EFA99
		// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x000F18A1 File Offset: 0x000EFAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerPrefs ServerPrefs
		{
			get
			{
				return this.serverPrefs_;
			}
			set
			{
				this.serverPrefs_ = value;
			}
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x000F18AA File Offset: 0x000EFAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetServerPrefsDataScRsp);
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x000F18B8 File Offset: 0x000EFAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetServerPrefsDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.ServerPrefs, other.ServerPrefs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x000F1908 File Offset: 0x000EFB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.serverPrefs_ != null)
			{
				num ^= this.ServerPrefs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x000F195D File Offset: 0x000EFB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x000F1965 File Offset: 0x000EFB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x000F1970 File Offset: 0x000EFB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.serverPrefs_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ServerPrefs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x000F19CC File Offset: 0x000EFBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.serverPrefs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ServerPrefs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x000F1A24 File Offset: 0x000EFC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetServerPrefsDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.serverPrefs_ != null)
			{
				if (this.serverPrefs_ == null)
				{
					this.ServerPrefs = new ServerPrefs();
				}
				this.ServerPrefs.MergeFrom(other.ServerPrefs);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x000F1A8C File Offset: 0x000EFC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x000F1A98 File Offset: 0x000EFC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.serverPrefs_ == null)
						{
							this.ServerPrefs = new ServerPrefs();
						}
						input.ReadMessage(this.ServerPrefs);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002328 RID: 9000
		private static readonly MessageParser<GetServerPrefsDataScRsp> _parser = new MessageParser<GetServerPrefsDataScRsp>(() => new GetServerPrefsDataScRsp());

		// Token: 0x04002329 RID: 9001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400232A RID: 9002
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400232B RID: 9003
		private uint retcode_;

		// Token: 0x0400232C RID: 9004
		public const int ServerPrefsFieldNumber = 13;

		// Token: 0x0400232D RID: 9005
		private ServerPrefs serverPrefs_;
	}
}
