using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BD9 RID: 3033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmDataCsReq : IMessage<MusicRhythmDataCsReq>, IMessage, IEquatable<MusicRhythmDataCsReq>, IDeepCloneable<MusicRhythmDataCsReq>, IBufferMessage
	{
		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06008635 RID: 34357 RVA: 0x0016230C File Offset: 0x0016050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmDataCsReq> Parser
		{
			get
			{
				return MusicRhythmDataCsReq._parser;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06008636 RID: 34358 RVA: 0x00162313 File Offset: 0x00160513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06008637 RID: 34359 RVA: 0x00162325 File Offset: 0x00160525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmDataCsReq.Descriptor;
			}
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x0016232C File Offset: 0x0016052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmDataCsReq()
		{
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x00162334 File Offset: 0x00160534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmDataCsReq(MusicRhythmDataCsReq other) : this()
		{
			this.playerData_ = other.playerData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x00162359 File Offset: 0x00160559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmDataCsReq Clone()
		{
			return new MusicRhythmDataCsReq(this);
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x0600863B RID: 34363 RVA: 0x00162361 File Offset: 0x00160561
		// (set) Token: 0x0600863C RID: 34364 RVA: 0x00162369 File Offset: 0x00160569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlayerData
		{
			get
			{
				return this.playerData_;
			}
			set
			{
				this.playerData_ = value;
			}
		}

		// Token: 0x0600863D RID: 34365 RVA: 0x00162372 File Offset: 0x00160572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmDataCsReq);
		}

		// Token: 0x0600863E RID: 34366 RVA: 0x00162380 File Offset: 0x00160580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmDataCsReq other)
		{
			return other != null && (other == this || (this.PlayerData == other.PlayerData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600863F RID: 34367 RVA: 0x001623B0 File Offset: 0x001605B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerData != 0U)
			{
				num ^= this.PlayerData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008640 RID: 34368 RVA: 0x001623EF File Offset: 0x001605EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008641 RID: 34369 RVA: 0x001623F7 File Offset: 0x001605F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008642 RID: 34370 RVA: 0x00162400 File Offset: 0x00160600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerData != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PlayerData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008643 RID: 34371 RVA: 0x00162434 File Offset: 0x00160634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerData != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlayerData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x00162472 File Offset: 0x00160672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerData != 0U)
			{
				this.PlayerData = other.PlayerData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x001624A3 File Offset: 0x001606A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x001624AC File Offset: 0x001606AC
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
					this.PlayerData = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003364 RID: 13156
		private static readonly MessageParser<MusicRhythmDataCsReq> _parser = new MessageParser<MusicRhythmDataCsReq>(() => new MusicRhythmDataCsReq());

		// Token: 0x04003365 RID: 13157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003366 RID: 13158
		public const int PlayerDataFieldNumber = 6;

		// Token: 0x04003367 RID: 13159
		private uint playerData_;
	}
}
