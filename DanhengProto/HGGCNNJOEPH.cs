using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E3 RID: 2275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HGGCNNJOEPH : IMessage<HGGCNNJOEPH>, IMessage, IEquatable<HGGCNNJOEPH>, IDeepCloneable<HGGCNNJOEPH>, IBufferMessage
	{
		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x0010F39D File Offset: 0x0010D59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HGGCNNJOEPH> Parser
		{
			get
			{
				return HGGCNNJOEPH._parser;
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x0010F3A4 File Offset: 0x0010D5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HGGCNNJOEPHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x0010F3B6 File Offset: 0x0010D5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HGGCNNJOEPH.Descriptor;
			}
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x0010F3BD File Offset: 0x0010D5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGGCNNJOEPH()
		{
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x0010F3D0 File Offset: 0x0010D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGGCNNJOEPH(HGGCNNJOEPH other) : this()
		{
			this.costTime_ = other.costTime_;
			this.fGLGBEEEAIC_ = other.fGLGBEEEAIC_.Clone();
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x0010F41D File Offset: 0x0010D61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGGCNNJOEPH Clone()
		{
			return new HGGCNNJOEPH(this);
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x0010F425 File Offset: 0x0010D625
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x0010F42D File Offset: 0x0010D62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x0010F436 File Offset: 0x0010D636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DFFKMEPPCFE> FGLGBEEEAIC
		{
			get
			{
				return this.fGLGBEEEAIC_;
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x0600657A RID: 25978 RVA: 0x0010F43E File Offset: 0x0010D63E
		// (set) Token: 0x0600657B RID: 25979 RVA: 0x0010F446 File Offset: 0x0010D646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x0010F44F File Offset: 0x0010D64F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HGGCNNJOEPH);
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x0010F460 File Offset: 0x0010D660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HGGCNNJOEPH other)
		{
			return other != null && (other == this || (this.CostTime == other.CostTime && this.fGLGBEEEAIC_.Equals(other.fGLGBEEEAIC_) && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x0010F4C0 File Offset: 0x0010D6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CostTime != 0U)
			{
				num ^= this.CostTime.GetHashCode();
			}
			num ^= this.fGLGBEEEAIC_.GetHashCode();
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x0010F526 File Offset: 0x0010D726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x0010F52E File Offset: 0x0010D72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x0010F538 File Offset: 0x0010D738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostTime != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.CostTime);
			}
			this.fGLGBEEEAIC_.WriteTo(ref output, HGGCNNJOEPH._repeated_fGLGBEEEAIC_codec);
			if (this.MapId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x0010F5A4 File Offset: 0x0010D7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CostTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CostTime);
			}
			num += this.fGLGBEEEAIC_.CalculateSize(HGGCNNJOEPH._repeated_fGLGBEEEAIC_codec);
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x0010F610 File Offset: 0x0010D810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HGGCNNJOEPH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CostTime != 0U)
			{
				this.CostTime = other.CostTime;
			}
			this.fGLGBEEEAIC_.Add(other.fGLGBEEEAIC_);
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x0010F671 File Offset: 0x0010D871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x0010F67C File Offset: 0x0010D87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 90U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MapId = input.ReadUInt32();
						}
					}
					else
					{
						this.fGLGBEEEAIC_.AddEntriesFrom(ref input, HGGCNNJOEPH._repeated_fGLGBEEEAIC_codec);
					}
				}
				else
				{
					this.CostTime = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002702 RID: 9986
		private static readonly MessageParser<HGGCNNJOEPH> _parser = new MessageParser<HGGCNNJOEPH>(() => new HGGCNNJOEPH());

		// Token: 0x04002703 RID: 9987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002704 RID: 9988
		public const int CostTimeFieldNumber = 7;

		// Token: 0x04002705 RID: 9989
		private uint costTime_;

		// Token: 0x04002706 RID: 9990
		public const int FGLGBEEEAICFieldNumber = 11;

		// Token: 0x04002707 RID: 9991
		private static readonly FieldCodec<DFFKMEPPCFE> _repeated_fGLGBEEEAIC_codec = FieldCodec.ForMessage<DFFKMEPPCFE>(90U, DFFKMEPPCFE.Parser);

		// Token: 0x04002708 RID: 9992
		private readonly RepeatedField<DFFKMEPPCFE> fGLGBEEEAIC_ = new RepeatedField<DFFKMEPPCFE>();

		// Token: 0x04002709 RID: 9993
		public const int MapIdFieldNumber = 13;

		// Token: 0x0400270A RID: 9994
		private uint mapId_;
	}
}
