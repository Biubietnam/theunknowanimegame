using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011D5 RID: 4565
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartTrackPhotoStageCsReq : IMessage<StartTrackPhotoStageCsReq>, IMessage, IEquatable<StartTrackPhotoStageCsReq>, IDeepCloneable<StartTrackPhotoStageCsReq>, IBufferMessage
	{
		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600CC0F RID: 52239 RVA: 0x00223D2D File Offset: 0x00221F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartTrackPhotoStageCsReq> Parser
		{
			get
			{
				return StartTrackPhotoStageCsReq._parser;
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600CC10 RID: 52240 RVA: 0x00223D34 File Offset: 0x00221F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartTrackPhotoStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600CC11 RID: 52241 RVA: 0x00223D46 File Offset: 0x00221F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartTrackPhotoStageCsReq.Descriptor;
			}
		}

		// Token: 0x0600CC12 RID: 52242 RVA: 0x00223D4D File Offset: 0x00221F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrackPhotoStageCsReq()
		{
		}

		// Token: 0x0600CC13 RID: 52243 RVA: 0x00223D55 File Offset: 0x00221F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrackPhotoStageCsReq(StartTrackPhotoStageCsReq other) : this()
		{
			this.stageId_ = other.stageId_;
			this.jMAPEPGLENN_ = other.jMAPEPGLENN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CC14 RID: 52244 RVA: 0x00223D86 File Offset: 0x00221F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartTrackPhotoStageCsReq Clone()
		{
			return new StartTrackPhotoStageCsReq(this);
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600CC15 RID: 52245 RVA: 0x00223D8E File Offset: 0x00221F8E
		// (set) Token: 0x0600CC16 RID: 52246 RVA: 0x00223D96 File Offset: 0x00221F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600CC17 RID: 52247 RVA: 0x00223D9F File Offset: 0x00221F9F
		// (set) Token: 0x0600CC18 RID: 52248 RVA: 0x00223DA7 File Offset: 0x00221FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JMAPEPGLENN
		{
			get
			{
				return this.jMAPEPGLENN_;
			}
			set
			{
				this.jMAPEPGLENN_ = value;
			}
		}

		// Token: 0x0600CC19 RID: 52249 RVA: 0x00223DB0 File Offset: 0x00221FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartTrackPhotoStageCsReq);
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x00223DBE File Offset: 0x00221FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartTrackPhotoStageCsReq other)
		{
			return other != null && (other == this || (this.StageId == other.StageId && this.JMAPEPGLENN == other.JMAPEPGLENN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x00223DFC File Offset: 0x00221FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.JMAPEPGLENN)
			{
				num ^= this.JMAPEPGLENN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x00223E54 File Offset: 0x00222054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x00223E5C File Offset: 0x0022205C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CC1E RID: 52254 RVA: 0x00223E68 File Offset: 0x00222068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.StageId);
			}
			if (this.JMAPEPGLENN)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.JMAPEPGLENN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CC1F RID: 52255 RVA: 0x00223EC4 File Offset: 0x002220C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this.JMAPEPGLENN)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CC20 RID: 52256 RVA: 0x00223F10 File Offset: 0x00222110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartTrackPhotoStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			if (other.JMAPEPGLENN)
			{
				this.JMAPEPGLENN = other.JMAPEPGLENN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x00223F60 File Offset: 0x00222160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CC22 RID: 52258 RVA: 0x00223F6C File Offset: 0x0022216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JMAPEPGLENN = input.ReadBool();
					}
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005251 RID: 21073
		private static readonly MessageParser<StartTrackPhotoStageCsReq> _parser = new MessageParser<StartTrackPhotoStageCsReq>(() => new StartTrackPhotoStageCsReq());

		// Token: 0x04005252 RID: 21074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005253 RID: 21075
		public const int StageIdFieldNumber = 9;

		// Token: 0x04005254 RID: 21076
		private uint stageId_;

		// Token: 0x04005255 RID: 21077
		public const int JMAPEPGLENNFieldNumber = 13;

		// Token: 0x04005256 RID: 21078
		private bool jMAPEPGLENN_;
	}
}
