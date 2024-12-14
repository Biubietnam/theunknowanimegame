using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BDD RID: 3037
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmFinishLevelCsReq : IMessage<MusicRhythmFinishLevelCsReq>, IMessage, IEquatable<MusicRhythmFinishLevelCsReq>, IDeepCloneable<MusicRhythmFinishLevelCsReq>, IBufferMessage
	{
		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x0600866A RID: 34410 RVA: 0x00162E19 File Offset: 0x00161019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmFinishLevelCsReq> Parser
		{
			get
			{
				return MusicRhythmFinishLevelCsReq._parser;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x0600866B RID: 34411 RVA: 0x00162E20 File Offset: 0x00161020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmFinishLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x0600866C RID: 34412 RVA: 0x00162E32 File Offset: 0x00161032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmFinishLevelCsReq.Descriptor;
			}
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x00162E39 File Offset: 0x00161039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmFinishLevelCsReq()
		{
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x00162E41 File Offset: 0x00161041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmFinishLevelCsReq(MusicRhythmFinishLevelCsReq other) : this()
		{
			this.scoreId_ = other.scoreId_;
			this.finishLevel_ = other.finishLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00162E72 File Offset: 0x00161072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmFinishLevelCsReq Clone()
		{
			return new MusicRhythmFinishLevelCsReq(this);
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06008670 RID: 34416 RVA: 0x00162E7A File Offset: 0x0016107A
		// (set) Token: 0x06008671 RID: 34417 RVA: 0x00162E82 File Offset: 0x00161082
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

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06008672 RID: 34418 RVA: 0x00162E8B File Offset: 0x0016108B
		// (set) Token: 0x06008673 RID: 34419 RVA: 0x00162E93 File Offset: 0x00161093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FinishLevel
		{
			get
			{
				return this.finishLevel_;
			}
			set
			{
				this.finishLevel_ = value;
			}
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x00162E9C File Offset: 0x0016109C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmFinishLevelCsReq);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x00162EAA File Offset: 0x001610AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmFinishLevelCsReq other)
		{
			return other != null && (other == this || (this.ScoreId == other.ScoreId && this.FinishLevel == other.FinishLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00162EE8 File Offset: 0x001610E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.FinishLevel != 0U)
			{
				num ^= this.FinishLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x00162F40 File Offset: 0x00161140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x00162F48 File Offset: 0x00161148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x00162F54 File Offset: 0x00161154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FinishLevel != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.FinishLevel);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x00162FB0 File Offset: 0x001611B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.FinishLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FinishLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x00163008 File Offset: 0x00161208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmFinishLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.FinishLevel != 0U)
			{
				this.FinishLevel = other.FinishLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x00163058 File Offset: 0x00161258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x00163064 File Offset: 0x00161264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ScoreId = input.ReadUInt32();
					}
				}
				else
				{
					this.FinishLevel = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003383 RID: 13187
		private static readonly MessageParser<MusicRhythmFinishLevelCsReq> _parser = new MessageParser<MusicRhythmFinishLevelCsReq>(() => new MusicRhythmFinishLevelCsReq());

		// Token: 0x04003384 RID: 13188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003385 RID: 13189
		public const int ScoreIdFieldNumber = 12;

		// Token: 0x04003386 RID: 13190
		private uint scoreId_;

		// Token: 0x04003387 RID: 13191
		public const int FinishLevelFieldNumber = 11;

		// Token: 0x04003388 RID: 13192
		private uint finishLevel_;
	}
}
