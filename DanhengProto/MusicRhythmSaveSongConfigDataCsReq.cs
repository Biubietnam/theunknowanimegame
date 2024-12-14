using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BE7 RID: 3047
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmSaveSongConfigDataCsReq : IMessage<MusicRhythmSaveSongConfigDataCsReq>, IMessage, IEquatable<MusicRhythmSaveSongConfigDataCsReq>, IDeepCloneable<MusicRhythmSaveSongConfigDataCsReq>, IBufferMessage
	{
		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x00163EF3 File Offset: 0x001620F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmSaveSongConfigDataCsReq> Parser
		{
			get
			{
				return MusicRhythmSaveSongConfigDataCsReq._parser;
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x060086DE RID: 34526 RVA: 0x00163EFA File Offset: 0x001620FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmSaveSongConfigDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x00163F0C File Offset: 0x0016210C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmSaveSongConfigDataCsReq.Descriptor;
			}
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x00163F13 File Offset: 0x00162113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmSaveSongConfigDataCsReq()
		{
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x00163F1B File Offset: 0x0016211B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmSaveSongConfigDataCsReq(MusicRhythmSaveSongConfigDataCsReq other) : this()
		{
			this.cOAAHHCMIGA_ = ((other.cOAAHHCMIGA_ != null) ? other.cOAAHHCMIGA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x00163F50 File Offset: 0x00162150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmSaveSongConfigDataCsReq Clone()
		{
			return new MusicRhythmSaveSongConfigDataCsReq(this);
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x00163F58 File Offset: 0x00162158
		// (set) Token: 0x060086E4 RID: 34532 RVA: 0x00163F60 File Offset: 0x00162160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmGroup COAAHHCMIGA
		{
			get
			{
				return this.cOAAHHCMIGA_;
			}
			set
			{
				this.cOAAHHCMIGA_ = value;
			}
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x00163F69 File Offset: 0x00162169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmSaveSongConfigDataCsReq);
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x00163F77 File Offset: 0x00162177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmSaveSongConfigDataCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.COAAHHCMIGA, other.COAAHHCMIGA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x00163FAC File Offset: 0x001621AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cOAAHHCMIGA_ != null)
			{
				num ^= this.COAAHHCMIGA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x00163FE8 File Offset: 0x001621E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x00163FF0 File Offset: 0x001621F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x00163FF9 File Offset: 0x001621F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cOAAHHCMIGA_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.COAAHHCMIGA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x0016402C File Offset: 0x0016222C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cOAAHHCMIGA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.COAAHHCMIGA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x0016406C File Offset: 0x0016226C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmSaveSongConfigDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cOAAHHCMIGA_ != null)
			{
				if (this.cOAAHHCMIGA_ == null)
				{
					this.COAAHHCMIGA = new MusicRhythmGroup();
				}
				this.COAAHHCMIGA.MergeFrom(other.COAAHHCMIGA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x001640C0 File Offset: 0x001622C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x001640CC File Offset: 0x001622CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.cOAAHHCMIGA_ == null)
					{
						this.COAAHHCMIGA = new MusicRhythmGroup();
					}
					input.ReadMessage(this.COAAHHCMIGA);
				}
			}
		}

		// Token: 0x040033AA RID: 13226
		private static readonly MessageParser<MusicRhythmSaveSongConfigDataCsReq> _parser = new MessageParser<MusicRhythmSaveSongConfigDataCsReq>(() => new MusicRhythmSaveSongConfigDataCsReq());

		// Token: 0x040033AB RID: 13227
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033AC RID: 13228
		public const int COAAHHCMIGAFieldNumber = 5;

		// Token: 0x040033AD RID: 13229
		private MusicRhythmGroup cOAAHHCMIGA_;
	}
}
