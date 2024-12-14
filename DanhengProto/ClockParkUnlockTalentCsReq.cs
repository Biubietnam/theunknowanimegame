using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000301 RID: 769
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkUnlockTalentCsReq : IMessage<ClockParkUnlockTalentCsReq>, IMessage, IEquatable<ClockParkUnlockTalentCsReq>, IDeepCloneable<ClockParkUnlockTalentCsReq>, IBufferMessage
	{
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00061C84 File Offset: 0x0005FE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkUnlockTalentCsReq> Parser
		{
			get
			{
				return ClockParkUnlockTalentCsReq._parser;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x00061C8B File Offset: 0x0005FE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkUnlockTalentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00061C9D File Offset: 0x0005FE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkUnlockTalentCsReq.Descriptor;
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00061CA4 File Offset: 0x0005FEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUnlockTalentCsReq()
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00061CAC File Offset: 0x0005FEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUnlockTalentCsReq(ClockParkUnlockTalentCsReq other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00061CD1 File Offset: 0x0005FED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkUnlockTalentCsReq Clone()
		{
			return new ClockParkUnlockTalentCsReq(this);
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00061CD9 File Offset: 0x0005FED9
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x00061CE1 File Offset: 0x0005FEE1
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

		// Token: 0x06002268 RID: 8808 RVA: 0x00061CEA File Offset: 0x0005FEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkUnlockTalentCsReq);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00061CF8 File Offset: 0x0005FEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkUnlockTalentCsReq other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00061D28 File Offset: 0x0005FF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600226B RID: 8811 RVA: 0x00061D67 File Offset: 0x0005FF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00061D6F File Offset: 0x0005FF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00061D78 File Offset: 0x0005FF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00061DAC File Offset: 0x0005FFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600226F RID: 8815 RVA: 0x00061DEA File Offset: 0x0005FFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkUnlockTalentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0U)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00061E1B File Offset: 0x0006001B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00061E24 File Offset: 0x00060024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E2F RID: 3631
		private static readonly MessageParser<ClockParkUnlockTalentCsReq> _parser = new MessageParser<ClockParkUnlockTalentCsReq>(() => new ClockParkUnlockTalentCsReq());

		// Token: 0x04000E30 RID: 3632
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E31 RID: 3633
		public const int TalentIdFieldNumber = 6;

		// Token: 0x04000E32 RID: 3634
		private uint talentId_;
	}
}
