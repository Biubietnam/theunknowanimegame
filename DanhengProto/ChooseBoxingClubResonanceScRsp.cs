using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002C3 RID: 707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChooseBoxingClubResonanceScRsp : IMessage<ChooseBoxingClubResonanceScRsp>, IMessage, IEquatable<ChooseBoxingClubResonanceScRsp>, IDeepCloneable<ChooseBoxingClubResonanceScRsp>, IBufferMessage
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x000597DF File Offset: 0x000579DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChooseBoxingClubResonanceScRsp> Parser
		{
			get
			{
				return ChooseBoxingClubResonanceScRsp._parser;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x000597E6 File Offset: 0x000579E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChooseBoxingClubResonanceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x000597F8 File Offset: 0x000579F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChooseBoxingClubResonanceScRsp.Descriptor;
			}
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000597FF File Offset: 0x000579FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubResonanceScRsp()
		{
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00059808 File Offset: 0x00057A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubResonanceScRsp(ChooseBoxingClubResonanceScRsp other) : this()
		{
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00059854 File Offset: 0x00057A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChooseBoxingClubResonanceScRsp Clone()
		{
			return new ChooseBoxingClubResonanceScRsp(this);
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0005985C File Offset: 0x00057A5C
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00059864 File Offset: 0x00057A64
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

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0005986D File Offset: 0x00057A6D
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00059875 File Offset: 0x00057A75
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

		// Token: 0x06001F70 RID: 8048 RVA: 0x0005987E File Offset: 0x00057A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChooseBoxingClubResonanceScRsp);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0005988C File Offset: 0x00057A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChooseBoxingClubResonanceScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Challenge, other.Challenge) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x000598DC File Offset: 0x00057ADC
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

		// Token: 0x06001F73 RID: 8051 RVA: 0x00059931 File Offset: 0x00057B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00059939 File Offset: 0x00057B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00059944 File Offset: 0x00057B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.challenge_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0005999C File Offset: 0x00057B9C
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

		// Token: 0x06001F77 RID: 8055 RVA: 0x000599F4 File Offset: 0x00057BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChooseBoxingClubResonanceScRsp other)
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

		// Token: 0x06001F78 RID: 8056 RVA: 0x00059A5C File Offset: 0x00057C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00059A68 File Offset: 0x00057C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D05 RID: 3333
		private static readonly MessageParser<ChooseBoxingClubResonanceScRsp> _parser = new MessageParser<ChooseBoxingClubResonanceScRsp>(() => new ChooseBoxingClubResonanceScRsp());

		// Token: 0x04000D06 RID: 3334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D07 RID: 3335
		public const int ChallengeFieldNumber = 8;

		// Token: 0x04000D08 RID: 3336
		private LJLLHIJKKOH challenge_;

		// Token: 0x04000D09 RID: 3337
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000D0A RID: 3338
		private uint retcode_;
	}
}
