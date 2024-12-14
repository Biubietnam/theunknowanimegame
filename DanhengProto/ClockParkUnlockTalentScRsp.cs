using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000303 RID: 771
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkUnlockTalentScRsp : IMessage<ClockParkUnlockTalentScRsp>, IMessage, IEquatable<ClockParkUnlockTalentScRsp>, IDeepCloneable<ClockParkUnlockTalentScRsp>, IBufferMessage
	{
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x00061F01 File Offset: 0x00060101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkUnlockTalentScRsp> Parser
		{
			get
			{
				return ClockParkUnlockTalentScRsp._parser;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x00061F08 File Offset: 0x00060108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkUnlockTalentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x00061F1A File Offset: 0x0006011A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkUnlockTalentScRsp.Descriptor;
			}
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00061F21 File Offset: 0x00060121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUnlockTalentScRsp()
		{
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00061F29 File Offset: 0x00060129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUnlockTalentScRsp(ClockParkUnlockTalentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00061F5A File Offset: 0x0006015A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUnlockTalentScRsp Clone()
		{
			return new ClockParkUnlockTalentScRsp(this);
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x00061F62 File Offset: 0x00060162
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x00061F6A File Offset: 0x0006016A
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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x00061F73 File Offset: 0x00060173
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x00061F7B File Offset: 0x0006017B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00061F84 File Offset: 0x00060184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkUnlockTalentScRsp);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00061F92 File Offset: 0x00060192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkUnlockTalentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00061FD0 File Offset: 0x000601D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.TalentId != 0U)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00062028 File Offset: 0x00060228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00062030 File Offset: 0x00060230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x0006203C File Offset: 0x0006023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TalentId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00062094 File Offset: 0x00060294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.TalentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000620EC File Offset: 0x000602EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkUnlockTalentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.TalentId != 0U)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x0006213C File Offset: 0x0006033C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00062148 File Offset: 0x00060348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 80U)
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
					this.TalentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E34 RID: 3636
		private static readonly MessageParser<ClockParkUnlockTalentScRsp> _parser = new MessageParser<ClockParkUnlockTalentScRsp>(() => new ClockParkUnlockTalentScRsp());

		// Token: 0x04000E35 RID: 3637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E36 RID: 3638
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04000E37 RID: 3639
		private uint retcode_;

		// Token: 0x04000E38 RID: 3640
		public const int TalentIdFieldNumber = 1;

		// Token: 0x04000E39 RID: 3641
		private uint talentId_;
	}
}
