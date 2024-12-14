using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BED RID: 3053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmStartLevelScRsp : IMessage<MusicRhythmStartLevelScRsp>, IMessage, IEquatable<MusicRhythmStartLevelScRsp>, IDeepCloneable<MusicRhythmStartLevelScRsp>, IBufferMessage
	{
		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06008720 RID: 34592 RVA: 0x0016481D File Offset: 0x00162A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmStartLevelScRsp> Parser
		{
			get
			{
				return MusicRhythmStartLevelScRsp._parser;
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06008721 RID: 34593 RVA: 0x00164824 File Offset: 0x00162A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmStartLevelScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06008722 RID: 34594 RVA: 0x00164836 File Offset: 0x00162A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmStartLevelScRsp.Descriptor;
			}
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x0016483D File Offset: 0x00162A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmStartLevelScRsp()
		{
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x00164850 File Offset: 0x00162A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmStartLevelScRsp(MusicRhythmStartLevelScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.levelId_ = other.levelId_;
			this.nJOONPFKHGE_ = other.nJOONPFKHGE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x0016488D File Offset: 0x00162A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmStartLevelScRsp Clone()
		{
			return new MusicRhythmStartLevelScRsp(this);
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06008726 RID: 34598 RVA: 0x00164895 File Offset: 0x00162A95
		// (set) Token: 0x06008727 RID: 34599 RVA: 0x0016489D File Offset: 0x00162A9D
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

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06008728 RID: 34600 RVA: 0x001648A6 File Offset: 0x00162AA6
		// (set) Token: 0x06008729 RID: 34601 RVA: 0x001648AE File Offset: 0x00162AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x0600872A RID: 34602 RVA: 0x001648B7 File Offset: 0x00162AB7
		// (set) Token: 0x0600872B RID: 34603 RVA: 0x001648BF File Offset: 0x00162ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string NJOONPFKHGE
		{
			get
			{
				return this.nJOONPFKHGE_;
			}
			set
			{
				this.nJOONPFKHGE_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600872C RID: 34604 RVA: 0x001648D2 File Offset: 0x00162AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmStartLevelScRsp);
		}

		// Token: 0x0600872D RID: 34605 RVA: 0x001648E0 File Offset: 0x00162AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmStartLevelScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.LevelId == other.LevelId && !(this.NJOONPFKHGE != other.NJOONPFKHGE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600872E RID: 34606 RVA: 0x00164940 File Offset: 0x00162B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.NJOONPFKHGE.Length != 0)
			{
				num ^= this.NJOONPFKHGE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600872F RID: 34607 RVA: 0x001649B3 File Offset: 0x00162BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x001649BB File Offset: 0x00162BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x001649C4 File Offset: 0x00162BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LevelId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.NJOONPFKHGE.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.NJOONPFKHGE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x00164A40 File Offset: 0x00162C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			if (this.NJOONPFKHGE.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.NJOONPFKHGE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00164AB4 File Offset: 0x00162CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmStartLevelScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			if (other.NJOONPFKHGE.Length != 0)
			{
				this.NJOONPFKHGE = other.NJOONPFKHGE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00164B1D File Offset: 0x00162D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00164B28 File Offset: 0x00162D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NJOONPFKHGE = input.ReadString();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040033BD RID: 13245
		private static readonly MessageParser<MusicRhythmStartLevelScRsp> _parser = new MessageParser<MusicRhythmStartLevelScRsp>(() => new MusicRhythmStartLevelScRsp());

		// Token: 0x040033BE RID: 13246
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033BF RID: 13247
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040033C0 RID: 13248
		private uint retcode_;

		// Token: 0x040033C1 RID: 13249
		public const int LevelIdFieldNumber = 3;

		// Token: 0x040033C2 RID: 13250
		private uint levelId_;

		// Token: 0x040033C3 RID: 13251
		public const int NJOONPFKHGEFieldNumber = 8;

		// Token: 0x040033C4 RID: 13252
		private string nJOONPFKHGE_ = "";
	}
}
