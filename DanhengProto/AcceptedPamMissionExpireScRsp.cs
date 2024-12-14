using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000013 RID: 19
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptedPamMissionExpireScRsp : IMessage<AcceptedPamMissionExpireScRsp>, IMessage, IEquatable<AcceptedPamMissionExpireScRsp>, IDeepCloneable<AcceptedPamMissionExpireScRsp>, IBufferMessage
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003565 File Offset: 0x00001765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptedPamMissionExpireScRsp> Parser
		{
			get
			{
				return AcceptedPamMissionExpireScRsp._parser;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000356C File Offset: 0x0000176C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptedPamMissionExpireScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000357E File Offset: 0x0000177E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptedPamMissionExpireScRsp.Descriptor;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003585 File Offset: 0x00001785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptedPamMissionExpireScRsp()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000358D File Offset: 0x0000178D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptedPamMissionExpireScRsp(AcceptedPamMissionExpireScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mainMissionId_ = other.mainMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000035BE File Offset: 0x000017BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptedPamMissionExpireScRsp Clone()
		{
			return new AcceptedPamMissionExpireScRsp(this);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000035C6 File Offset: 0x000017C6
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000035CE File Offset: 0x000017CE
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000035D7 File Offset: 0x000017D7
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000035DF File Offset: 0x000017DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainMissionId
		{
			get
			{
				return this.mainMissionId_;
			}
			set
			{
				this.mainMissionId_ = value;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000035E8 File Offset: 0x000017E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptedPamMissionExpireScRsp);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000035F6 File Offset: 0x000017F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptedPamMissionExpireScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.MainMissionId == other.MainMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003634 File Offset: 0x00001834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000368C File Offset: 0x0000188C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003694 File Offset: 0x00001894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000036A0 File Offset: 0x000018A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000036FC File Offset: 0x000018FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003754 File Offset: 0x00001954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptedPamMissionExpireScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000037A4 File Offset: 0x000019A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000037B0 File Offset: 0x000019B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.MainMissionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000038 RID: 56
		private static readonly MessageParser<AcceptedPamMissionExpireScRsp> _parser = new MessageParser<AcceptedPamMissionExpireScRsp>(() => new AcceptedPamMissionExpireScRsp());

		// Token: 0x04000039 RID: 57
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400003A RID: 58
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400003B RID: 59
		private uint retcode_;

		// Token: 0x0400003C RID: 60
		public const int MainMissionIdFieldNumber = 5;

		// Token: 0x0400003D RID: 61
		private uint mainMissionId_;
	}
}
