using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BE9 RID: 3049
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmSaveSongConfigDataScRsp : IMessage<MusicRhythmSaveSongConfigDataScRsp>, IMessage, IEquatable<MusicRhythmSaveSongConfigDataScRsp>, IDeepCloneable<MusicRhythmSaveSongConfigDataScRsp>, IBufferMessage
	{
		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x060086F2 RID: 34546 RVA: 0x001641C1 File Offset: 0x001623C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmSaveSongConfigDataScRsp> Parser
		{
			get
			{
				return MusicRhythmSaveSongConfigDataScRsp._parser;
			}
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x060086F3 RID: 34547 RVA: 0x001641C8 File Offset: 0x001623C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmSaveSongConfigDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x060086F4 RID: 34548 RVA: 0x001641DA File Offset: 0x001623DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmSaveSongConfigDataScRsp.Descriptor;
			}
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x001641E1 File Offset: 0x001623E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmSaveSongConfigDataScRsp()
		{
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x001641E9 File Offset: 0x001623E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmSaveSongConfigDataScRsp(MusicRhythmSaveSongConfigDataScRsp other) : this()
		{
			this.aLCHNKEFMEN_ = other.aLCHNKEFMEN_;
			this.retcode_ = other.retcode_;
			this.curSongId_ = other.curSongId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x00164226 File Offset: 0x00162426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmSaveSongConfigDataScRsp Clone()
		{
			return new MusicRhythmSaveSongConfigDataScRsp(this);
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x060086F8 RID: 34552 RVA: 0x0016422E File Offset: 0x0016242E
		// (set) Token: 0x060086F9 RID: 34553 RVA: 0x00164236 File Offset: 0x00162436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALCHNKEFMEN
		{
			get
			{
				return this.aLCHNKEFMEN_;
			}
			set
			{
				this.aLCHNKEFMEN_ = value;
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x060086FA RID: 34554 RVA: 0x0016423F File Offset: 0x0016243F
		// (set) Token: 0x060086FB RID: 34555 RVA: 0x00164247 File Offset: 0x00162447
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

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x060086FC RID: 34556 RVA: 0x00164250 File Offset: 0x00162450
		// (set) Token: 0x060086FD RID: 34557 RVA: 0x00164258 File Offset: 0x00162458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurSongId
		{
			get
			{
				return this.curSongId_;
			}
			set
			{
				this.curSongId_ = value;
			}
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x00164261 File Offset: 0x00162461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmSaveSongConfigDataScRsp);
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x00164270 File Offset: 0x00162470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmSaveSongConfigDataScRsp other)
		{
			return other != null && (other == this || (this.ALCHNKEFMEN == other.ALCHNKEFMEN && this.Retcode == other.Retcode && this.CurSongId == other.CurSongId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x001642CC File Offset: 0x001624CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ALCHNKEFMEN != 0U)
			{
				num ^= this.ALCHNKEFMEN.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurSongId != 0U)
			{
				num ^= this.CurSongId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x0016433D File Offset: 0x0016253D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00164345 File Offset: 0x00162545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x00164350 File Offset: 0x00162550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ALCHNKEFMEN != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ALCHNKEFMEN);
			}
			if (this.CurSongId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.CurSongId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x001643C4 File Offset: 0x001625C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ALCHNKEFMEN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALCHNKEFMEN);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurSongId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurSongId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x00164434 File Offset: 0x00162634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmSaveSongConfigDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ALCHNKEFMEN != 0U)
			{
				this.ALCHNKEFMEN = other.ALCHNKEFMEN;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurSongId != 0U)
			{
				this.CurSongId = other.CurSongId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x00164498 File Offset: 0x00162698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x001644A4 File Offset: 0x001626A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 40U)
					{
						if (num != 120U)
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
						this.CurSongId = input.ReadUInt32();
					}
				}
				else
				{
					this.ALCHNKEFMEN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040033AF RID: 13231
		private static readonly MessageParser<MusicRhythmSaveSongConfigDataScRsp> _parser = new MessageParser<MusicRhythmSaveSongConfigDataScRsp>(() => new MusicRhythmSaveSongConfigDataScRsp());

		// Token: 0x040033B0 RID: 13232
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033B1 RID: 13233
		public const int ALCHNKEFMENFieldNumber = 1;

		// Token: 0x040033B2 RID: 13234
		private uint aLCHNKEFMEN_;

		// Token: 0x040033B3 RID: 13235
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040033B4 RID: 13236
		private uint retcode_;

		// Token: 0x040033B5 RID: 13237
		public const int CurSongIdFieldNumber = 5;

		// Token: 0x040033B6 RID: 13238
		private uint curSongId_;
	}
}
