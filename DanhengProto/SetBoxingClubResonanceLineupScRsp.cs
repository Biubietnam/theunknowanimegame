using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010D7 RID: 4311
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetBoxingClubResonanceLineupScRsp : IMessage<SetBoxingClubResonanceLineupScRsp>, IMessage, IEquatable<SetBoxingClubResonanceLineupScRsp>, IDeepCloneable<SetBoxingClubResonanceLineupScRsp>, IBufferMessage
	{
		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600C03B RID: 49211 RVA: 0x00205593 File Offset: 0x00203793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetBoxingClubResonanceLineupScRsp> Parser
		{
			get
			{
				return SetBoxingClubResonanceLineupScRsp._parser;
			}
		}

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600C03C RID: 49212 RVA: 0x0020559A File Offset: 0x0020379A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetBoxingClubResonanceLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600C03D RID: 49213 RVA: 0x002055AC File Offset: 0x002037AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBoxingClubResonanceLineupScRsp.Descriptor;
			}
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x002055B3 File Offset: 0x002037B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBoxingClubResonanceLineupScRsp()
		{
		}

		// Token: 0x0600C03F RID: 49215 RVA: 0x002055BC File Offset: 0x002037BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBoxingClubResonanceLineupScRsp(SetBoxingClubResonanceLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C040 RID: 49216 RVA: 0x00205608 File Offset: 0x00203808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBoxingClubResonanceLineupScRsp Clone()
		{
			return new SetBoxingClubResonanceLineupScRsp(this);
		}

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600C041 RID: 49217 RVA: 0x00205610 File Offset: 0x00203810
		// (set) Token: 0x0600C042 RID: 49218 RVA: 0x00205618 File Offset: 0x00203818
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

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600C043 RID: 49219 RVA: 0x00205621 File Offset: 0x00203821
		// (set) Token: 0x0600C044 RID: 49220 RVA: 0x00205629 File Offset: 0x00203829
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

		// Token: 0x0600C045 RID: 49221 RVA: 0x00205632 File Offset: 0x00203832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBoxingClubResonanceLineupScRsp);
		}

		// Token: 0x0600C046 RID: 49222 RVA: 0x00205640 File Offset: 0x00203840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBoxingClubResonanceLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Challenge, other.Challenge) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x00205690 File Offset: 0x00203890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.challenge_ != null)
			{
				num ^= this.Challenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x002056E5 File Offset: 0x002038E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x002056ED File Offset: 0x002038ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C04A RID: 49226 RVA: 0x002056F8 File Offset: 0x002038F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challenge_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Challenge);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C04B RID: 49227 RVA: 0x00205754 File Offset: 0x00203954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.challenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C04C RID: 49228 RVA: 0x002057AC File Offset: 0x002039AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBoxingClubResonanceLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.challenge_ != null)
			{
				if (this.challenge_ == null)
				{
					this.Challenge = new LJLLHIJKKOH();
				}
				this.Challenge.MergeFrom(other.Challenge);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C04D RID: 49229 RVA: 0x00205814 File Offset: 0x00203A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x00205820 File Offset: 0x00203A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 72U)
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

		// Token: 0x04004DFA RID: 19962
		private static readonly MessageParser<SetBoxingClubResonanceLineupScRsp> _parser = new MessageParser<SetBoxingClubResonanceLineupScRsp>(() => new SetBoxingClubResonanceLineupScRsp());

		// Token: 0x04004DFB RID: 19963
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DFC RID: 19964
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04004DFD RID: 19965
		private uint retcode_;

		// Token: 0x04004DFE RID: 19966
		public const int ChallengeFieldNumber = 3;

		// Token: 0x04004DFF RID: 19967
		private LJLLHIJKKOH challenge_;
	}
}
