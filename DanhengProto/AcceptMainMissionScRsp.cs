using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200001B RID: 27
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptMainMissionScRsp : IMessage<AcceptMainMissionScRsp>, IMessage, IEquatable<AcceptMainMissionScRsp>, IDeepCloneable<AcceptMainMissionScRsp>, IBufferMessage
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00004165 File Offset: 0x00002365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptMainMissionScRsp> Parser
		{
			get
			{
				return AcceptMainMissionScRsp._parser;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000416C File Offset: 0x0000236C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptMainMissionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000417E File Offset: 0x0000237E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptMainMissionScRsp.Descriptor;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004185 File Offset: 0x00002385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMainMissionScRsp()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000418D File Offset: 0x0000238D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMainMissionScRsp(AcceptMainMissionScRsp other) : this()
		{
			this.mainMissionId_ = other.mainMissionId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000041BE File Offset: 0x000023BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMainMissionScRsp Clone()
		{
			return new AcceptMainMissionScRsp(this);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000041C6 File Offset: 0x000023C6
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000041CE File Offset: 0x000023CE
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000041D7 File Offset: 0x000023D7
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000041DF File Offset: 0x000023DF
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

		// Token: 0x060000F0 RID: 240 RVA: 0x000041E8 File Offset: 0x000023E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptMainMissionScRsp);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000041F6 File Offset: 0x000023F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptMainMissionScRsp other)
		{
			return other != null && (other == this || (this.MainMissionId == other.MainMissionId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004234 File Offset: 0x00002434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainMissionId != 0U)
			{
				num ^= this.MainMissionId.GetHashCode();
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

		// Token: 0x060000F3 RID: 243 RVA: 0x0000428C File Offset: 0x0000248C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004294 File Offset: 0x00002494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000042A0 File Offset: 0x000024A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MainMissionId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MainMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000042F8 File Offset: 0x000024F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainMissionId);
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

		// Token: 0x060000F7 RID: 247 RVA: 0x00004350 File Offset: 0x00002550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptMainMissionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainMissionId != 0U)
			{
				this.MainMissionId = other.MainMissionId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000043A0 File Offset: 0x000025A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000043AC File Offset: 0x000025AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MainMissionId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly MessageParser<AcceptMainMissionScRsp> _parser = new MessageParser<AcceptMainMissionScRsp>(() => new AcceptMainMissionScRsp());

		// Token: 0x04000051 RID: 81
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000052 RID: 82
		public const int MainMissionIdFieldNumber = 5;

		// Token: 0x04000053 RID: 83
		private uint mainMissionId_;

		// Token: 0x04000054 RID: 84
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000055 RID: 85
		private uint retcode_;
	}
}
