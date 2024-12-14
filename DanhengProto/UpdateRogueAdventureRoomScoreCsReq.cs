using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F3 RID: 5107
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateRogueAdventureRoomScoreCsReq : IMessage<UpdateRogueAdventureRoomScoreCsReq>, IMessage, IEquatable<UpdateRogueAdventureRoomScoreCsReq>, IDeepCloneable<UpdateRogueAdventureRoomScoreCsReq>, IBufferMessage
	{
		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x0025DAC5 File Offset: 0x0025BCC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateRogueAdventureRoomScoreCsReq> Parser
		{
			get
			{
				return UpdateRogueAdventureRoomScoreCsReq._parser;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x0025DACC File Offset: 0x0025BCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateRogueAdventureRoomScoreCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x0600E3B9 RID: 58297 RVA: 0x0025DADE File Offset: 0x0025BCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRogueAdventureRoomScoreCsReq.Descriptor;
			}
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x0025DAE5 File Offset: 0x0025BCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRogueAdventureRoomScoreCsReq()
		{
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x0025DAED File Offset: 0x0025BCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRogueAdventureRoomScoreCsReq(UpdateRogueAdventureRoomScoreCsReq other) : this()
		{
			this.bELGPLFBDBP_ = other.bELGPLFBDBP_;
			this.scoreId_ = other.scoreId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x0025DB1E File Offset: 0x0025BD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRogueAdventureRoomScoreCsReq Clone()
		{
			return new UpdateRogueAdventureRoomScoreCsReq(this);
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x0025DB26 File Offset: 0x0025BD26
		// (set) Token: 0x0600E3BE RID: 58302 RVA: 0x0025DB2E File Offset: 0x0025BD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BELGPLFBDBP
		{
			get
			{
				return this.bELGPLFBDBP_;
			}
			set
			{
				this.bELGPLFBDBP_ = value;
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x0600E3BF RID: 58303 RVA: 0x0025DB37 File Offset: 0x0025BD37
		// (set) Token: 0x0600E3C0 RID: 58304 RVA: 0x0025DB3F File Offset: 0x0025BD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x0025DB48 File Offset: 0x0025BD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRogueAdventureRoomScoreCsReq);
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x0025DB56 File Offset: 0x0025BD56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateRogueAdventureRoomScoreCsReq other)
		{
			return other != null && (other == this || (this.BELGPLFBDBP == other.BELGPLFBDBP && this.ScoreId == other.ScoreId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x0025DB94 File Offset: 0x0025BD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BELGPLFBDBP != 0U)
			{
				num ^= this.BELGPLFBDBP.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x0025DBEC File Offset: 0x0025BDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x0025DBF4 File Offset: 0x0025BDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3C6 RID: 58310 RVA: 0x0025DC00 File Offset: 0x0025BE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.BELGPLFBDBP != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.BELGPLFBDBP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E3C7 RID: 58311 RVA: 0x0025DC5C File Offset: 0x0025BE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BELGPLFBDBP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BELGPLFBDBP);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3C8 RID: 58312 RVA: 0x0025DCB4 File Offset: 0x0025BEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateRogueAdventureRoomScoreCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BELGPLFBDBP != 0U)
			{
				this.BELGPLFBDBP = other.BELGPLFBDBP;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3C9 RID: 58313 RVA: 0x0025DD04 File Offset: 0x0025BF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3CA RID: 58314 RVA: 0x0025DD10 File Offset: 0x0025BF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BELGPLFBDBP = input.ReadUInt32();
					}
				}
				else
				{
					this.ScoreId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005A83 RID: 23171
		private static readonly MessageParser<UpdateRogueAdventureRoomScoreCsReq> _parser = new MessageParser<UpdateRogueAdventureRoomScoreCsReq>(() => new UpdateRogueAdventureRoomScoreCsReq());

		// Token: 0x04005A84 RID: 23172
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A85 RID: 23173
		public const int BELGPLFBDBPFieldNumber = 11;

		// Token: 0x04005A86 RID: 23174
		private uint bELGPLFBDBP_;

		// Token: 0x04005A87 RID: 23175
		public const int ScoreIdFieldNumber = 3;

		// Token: 0x04005A88 RID: 23176
		private uint scoreId_;
	}
}
