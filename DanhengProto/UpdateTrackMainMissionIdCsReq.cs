using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013FD RID: 5117
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateTrackMainMissionIdCsReq : IMessage<UpdateTrackMainMissionIdCsReq>, IMessage, IEquatable<UpdateTrackMainMissionIdCsReq>, IDeepCloneable<UpdateTrackMainMissionIdCsReq>, IBufferMessage
	{
		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x0600E425 RID: 58405 RVA: 0x0025EA57 File Offset: 0x0025CC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateTrackMainMissionIdCsReq> Parser
		{
			get
			{
				return UpdateTrackMainMissionIdCsReq._parser;
			}
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x0600E426 RID: 58406 RVA: 0x0025EA5E File Offset: 0x0025CC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateTrackMainMissionIdCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x0600E427 RID: 58407 RVA: 0x0025EA70 File Offset: 0x0025CC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateTrackMainMissionIdCsReq.Descriptor;
			}
		}

		// Token: 0x0600E428 RID: 58408 RVA: 0x0025EA77 File Offset: 0x0025CC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTrackMainMissionIdCsReq()
		{
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x0025EA7F File Offset: 0x0025CC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTrackMainMissionIdCsReq(UpdateTrackMainMissionIdCsReq other) : this()
		{
			this.jKJNMKMIDBP_ = other.jKJNMKMIDBP_;
			this.iLCCBCOJEOH_ = other.iLCCBCOJEOH_;
			this.trackMissionId_ = other.trackMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x0025EABC File Offset: 0x0025CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTrackMainMissionIdCsReq Clone()
		{
			return new UpdateTrackMainMissionIdCsReq(this);
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x0600E42B RID: 58411 RVA: 0x0025EAC4 File Offset: 0x0025CCC4
		// (set) Token: 0x0600E42C RID: 58412 RVA: 0x0025EACC File Offset: 0x0025CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMainMissionUpdateReasonId JKJNMKMIDBP
		{
			get
			{
				return this.jKJNMKMIDBP_;
			}
			set
			{
				this.jKJNMKMIDBP_ = value;
			}
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x0600E42D RID: 58413 RVA: 0x0025EAD5 File Offset: 0x0025CCD5
		// (set) Token: 0x0600E42E RID: 58414 RVA: 0x0025EADD File Offset: 0x0025CCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ILCCBCOJEOH
		{
			get
			{
				return this.iLCCBCOJEOH_;
			}
			set
			{
				this.iLCCBCOJEOH_ = value;
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x0600E42F RID: 58415 RVA: 0x0025EAE6 File Offset: 0x0025CCE6
		// (set) Token: 0x0600E430 RID: 58416 RVA: 0x0025EAEE File Offset: 0x0025CCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TrackMissionId
		{
			get
			{
				return this.trackMissionId_;
			}
			set
			{
				this.trackMissionId_ = value;
			}
		}

		// Token: 0x0600E431 RID: 58417 RVA: 0x0025EAF7 File Offset: 0x0025CCF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateTrackMainMissionIdCsReq);
		}

		// Token: 0x0600E432 RID: 58418 RVA: 0x0025EB08 File Offset: 0x0025CD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateTrackMainMissionIdCsReq other)
		{
			return other != null && (other == this || (this.JKJNMKMIDBP == other.JKJNMKMIDBP && this.ILCCBCOJEOH == other.ILCCBCOJEOH && this.TrackMissionId == other.TrackMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E433 RID: 58419 RVA: 0x0025EB64 File Offset: 0x0025CD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JKJNMKMIDBP != TrackMainMissionUpdateReasonId.TrackMainMissionUpdateNone)
			{
				num ^= this.JKJNMKMIDBP.GetHashCode();
			}
			if (this.ILCCBCOJEOH != 0U)
			{
				num ^= this.ILCCBCOJEOH.GetHashCode();
			}
			if (this.TrackMissionId != 0U)
			{
				num ^= this.TrackMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E434 RID: 58420 RVA: 0x0025EBDB File Offset: 0x0025CDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E435 RID: 58421 RVA: 0x0025EBE3 File Offset: 0x0025CDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E436 RID: 58422 RVA: 0x0025EBEC File Offset: 0x0025CDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JKJNMKMIDBP != TrackMainMissionUpdateReasonId.TrackMainMissionUpdateNone)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.JKJNMKMIDBP);
			}
			if (this.ILCCBCOJEOH != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ILCCBCOJEOH);
			}
			if (this.TrackMissionId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.TrackMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x0025EC64 File Offset: 0x0025CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JKJNMKMIDBP != TrackMainMissionUpdateReasonId.TrackMainMissionUpdateNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.JKJNMKMIDBP);
			}
			if (this.ILCCBCOJEOH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ILCCBCOJEOH);
			}
			if (this.TrackMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TrackMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E438 RID: 58424 RVA: 0x0025ECD4 File Offset: 0x0025CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateTrackMainMissionIdCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JKJNMKMIDBP != TrackMainMissionUpdateReasonId.TrackMainMissionUpdateNone)
			{
				this.JKJNMKMIDBP = other.JKJNMKMIDBP;
			}
			if (other.ILCCBCOJEOH != 0U)
			{
				this.ILCCBCOJEOH = other.ILCCBCOJEOH;
			}
			if (other.TrackMissionId != 0U)
			{
				this.TrackMissionId = other.TrackMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E439 RID: 58425 RVA: 0x0025ED38 File Offset: 0x0025CF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E43A RID: 58426 RVA: 0x0025ED44 File Offset: 0x0025CF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TrackMissionId = input.ReadUInt32();
						}
					}
					else
					{
						this.ILCCBCOJEOH = input.ReadUInt32();
					}
				}
				else
				{
					this.JKJNMKMIDBP = (TrackMainMissionUpdateReasonId)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005AA3 RID: 23203
		private static readonly MessageParser<UpdateTrackMainMissionIdCsReq> _parser = new MessageParser<UpdateTrackMainMissionIdCsReq>(() => new UpdateTrackMainMissionIdCsReq());

		// Token: 0x04005AA4 RID: 23204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AA5 RID: 23205
		public const int JKJNMKMIDBPFieldNumber = 4;

		// Token: 0x04005AA6 RID: 23206
		private TrackMainMissionUpdateReasonId jKJNMKMIDBP_;

		// Token: 0x04005AA7 RID: 23207
		public const int ILCCBCOJEOHFieldNumber = 7;

		// Token: 0x04005AA8 RID: 23208
		private uint iLCCBCOJEOH_;

		// Token: 0x04005AA9 RID: 23209
		public const int TrackMissionIdFieldNumber = 14;

		// Token: 0x04005AAA RID: 23210
		private uint trackMissionId_;
	}
}
