using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C65 RID: 3173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OMPEBDAOFIG : IMessage<OMPEBDAOFIG>, IMessage, IEquatable<OMPEBDAOFIG>, IDeepCloneable<OMPEBDAOFIG>, IBufferMessage
	{
		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x06008CF4 RID: 36084 RVA: 0x00174924 File Offset: 0x00172B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OMPEBDAOFIG> Parser
		{
			get
			{
				return OMPEBDAOFIG._parser;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x0017492B File Offset: 0x00172B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OMPEBDAOFIGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x06008CF6 RID: 36086 RVA: 0x0017493D File Offset: 0x00172B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OMPEBDAOFIG.Descriptor;
			}
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x00174944 File Offset: 0x00172B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPEBDAOFIG()
		{
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x0017494C File Offset: 0x00172B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPEBDAOFIG(OMPEBDAOFIG other) : this()
		{
			this.level_ = other.level_;
			this.mazeId_ = other.mazeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x0017497D File Offset: 0x00172B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPEBDAOFIG Clone()
		{
			return new OMPEBDAOFIG(this);
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x06008CFA RID: 36090 RVA: 0x00174985 File Offset: 0x00172B85
		// (set) Token: 0x06008CFB RID: 36091 RVA: 0x0017498D File Offset: 0x00172B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x06008CFC RID: 36092 RVA: 0x00174996 File Offset: 0x00172B96
		// (set) Token: 0x06008CFD RID: 36093 RVA: 0x0017499E File Offset: 0x00172B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MazeId
		{
			get
			{
				return this.mazeId_;
			}
			set
			{
				this.mazeId_ = value;
			}
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x001749A7 File Offset: 0x00172BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OMPEBDAOFIG);
		}

		// Token: 0x06008CFF RID: 36095 RVA: 0x001749B5 File Offset: 0x00172BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OMPEBDAOFIG other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MazeId == other.MazeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x001749F4 File Offset: 0x00172BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MazeId != 0U)
			{
				num ^= this.MazeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x00174A4C File Offset: 0x00172C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x00174A54 File Offset: 0x00172C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x00174A60 File Offset: 0x00172C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Level);
			}
			if (this.MazeId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MazeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D04 RID: 36100 RVA: 0x00174ABC File Offset: 0x00172CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.MazeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MazeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x00174B14 File Offset: 0x00172D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OMPEBDAOFIG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.MazeId != 0U)
			{
				this.MazeId = other.MazeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x00174B64 File Offset: 0x00172D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D07 RID: 36103 RVA: 0x00174B70 File Offset: 0x00172D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MazeId = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003622 RID: 13858
		private static readonly MessageParser<OMPEBDAOFIG> _parser = new MessageParser<OMPEBDAOFIG>(() => new OMPEBDAOFIG());

		// Token: 0x04003623 RID: 13859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003624 RID: 13860
		public const int LevelFieldNumber = 11;

		// Token: 0x04003625 RID: 13861
		private uint level_;

		// Token: 0x04003626 RID: 13862
		public const int MazeIdFieldNumber = 14;

		// Token: 0x04003627 RID: 13863
		private uint mazeId_;
	}
}
