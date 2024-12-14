using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002C7 RID: 711
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChooseBoxingClubStageOptionalBuffScRsp : IMessage<ChooseBoxingClubStageOptionalBuffScRsp>, IMessage, IEquatable<ChooseBoxingClubStageOptionalBuffScRsp>, IDeepCloneable<ChooseBoxingClubStageOptionalBuffScRsp>, IBufferMessage
	{
		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00059EC3 File Offset: 0x000580C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChooseBoxingClubStageOptionalBuffScRsp> Parser
		{
			get
			{
				return ChooseBoxingClubStageOptionalBuffScRsp._parser;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00059ECA File Offset: 0x000580CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChooseBoxingClubStageOptionalBuffScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00059EDC File Offset: 0x000580DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChooseBoxingClubStageOptionalBuffScRsp.Descriptor;
			}
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00059EE3 File Offset: 0x000580E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubStageOptionalBuffScRsp()
		{
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00059EEC File Offset: 0x000580EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubStageOptionalBuffScRsp(ChooseBoxingClubStageOptionalBuffScRsp other) : this()
		{
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00059F38 File Offset: 0x00058138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubStageOptionalBuffScRsp Clone()
		{
			return new ChooseBoxingClubStageOptionalBuffScRsp(this);
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00059F40 File Offset: 0x00058140
		// (set) Token: 0x06001F9B RID: 8091 RVA: 0x00059F48 File Offset: 0x00058148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH Challenge
		{
			get
			{
				return this.challenge_;
			}
			set
			{
				this.challenge_ = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00059F51 File Offset: 0x00058151
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00059F59 File Offset: 0x00058159
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

		// Token: 0x06001F9E RID: 8094 RVA: 0x00059F62 File Offset: 0x00058162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChooseBoxingClubStageOptionalBuffScRsp);
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00059F70 File Offset: 0x00058170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChooseBoxingClubStageOptionalBuffScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Challenge, other.Challenge) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00059FC0 File Offset: 0x000581C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.challenge_ != null)
			{
				num ^= this.Challenge.GetHashCode();
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

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0005A015 File Offset: 0x00058215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0005A01D File Offset: 0x0005821D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0005A028 File Offset: 0x00058228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challenge_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Challenge);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0005A084 File Offset: 0x00058284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.challenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Challenge);
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

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0005A0DC File Offset: 0x000582DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChooseBoxingClubStageOptionalBuffScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.challenge_ != null)
			{
				if (this.challenge_ == null)
				{
					this.Challenge = new LJLLHIJKKOH();
				}
				this.Challenge.MergeFrom(other.Challenge);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0005A144 File Offset: 0x00058344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0005A150 File Offset: 0x00058350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 96U)
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
					if (this.challenge_ == null)
					{
						this.Challenge = new LJLLHIJKKOH();
					}
					input.ReadMessage(this.Challenge);
				}
			}
		}

		// Token: 0x04000D13 RID: 3347
		private static readonly MessageParser<ChooseBoxingClubStageOptionalBuffScRsp> _parser = new MessageParser<ChooseBoxingClubStageOptionalBuffScRsp>(() => new ChooseBoxingClubStageOptionalBuffScRsp());

		// Token: 0x04000D14 RID: 3348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D15 RID: 3349
		public const int ChallengeFieldNumber = 5;

		// Token: 0x04000D16 RID: 3350
		private LJLLHIJKKOH challenge_;

		// Token: 0x04000D17 RID: 3351
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04000D18 RID: 3352
		private uint retcode_;
	}
}
