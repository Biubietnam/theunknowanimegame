using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013A7 RID: 5031
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TrialBackGroundMusicCsReq : IMessage<TrialBackGroundMusicCsReq>, IMessage, IEquatable<TrialBackGroundMusicCsReq>, IDeepCloneable<TrialBackGroundMusicCsReq>, IBufferMessage
	{
		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x0600E07B RID: 57467 RVA: 0x00255D8C File Offset: 0x00253F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrialBackGroundMusicCsReq> Parser
		{
			get
			{
				return TrialBackGroundMusicCsReq._parser;
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x0600E07C RID: 57468 RVA: 0x00255D93 File Offset: 0x00253F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TrialBackGroundMusicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x0600E07D RID: 57469 RVA: 0x00255DA5 File Offset: 0x00253FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialBackGroundMusicCsReq.Descriptor;
			}
		}

		// Token: 0x0600E07E RID: 57470 RVA: 0x00255DAC File Offset: 0x00253FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialBackGroundMusicCsReq()
		{
		}

		// Token: 0x0600E07F RID: 57471 RVA: 0x00255DB4 File Offset: 0x00253FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialBackGroundMusicCsReq(TrialBackGroundMusicCsReq other) : this()
		{
			this.hILGIGJMIFM_ = other.hILGIGJMIFM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E080 RID: 57472 RVA: 0x00255DD9 File Offset: 0x00253FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialBackGroundMusicCsReq Clone()
		{
			return new TrialBackGroundMusicCsReq(this);
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x0600E081 RID: 57473 RVA: 0x00255DE1 File Offset: 0x00253FE1
		// (set) Token: 0x0600E082 RID: 57474 RVA: 0x00255DE9 File Offset: 0x00253FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HILGIGJMIFM
		{
			get
			{
				return this.hILGIGJMIFM_;
			}
			set
			{
				this.hILGIGJMIFM_ = value;
			}
		}

		// Token: 0x0600E083 RID: 57475 RVA: 0x00255DF2 File Offset: 0x00253FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialBackGroundMusicCsReq);
		}

		// Token: 0x0600E084 RID: 57476 RVA: 0x00255E00 File Offset: 0x00254000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialBackGroundMusicCsReq other)
		{
			return other != null && (other == this || (this.HILGIGJMIFM == other.HILGIGJMIFM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E085 RID: 57477 RVA: 0x00255E30 File Offset: 0x00254030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HILGIGJMIFM != 0U)
			{
				num ^= this.HILGIGJMIFM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E086 RID: 57478 RVA: 0x00255E6F File Offset: 0x0025406F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E087 RID: 57479 RVA: 0x00255E77 File Offset: 0x00254077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E088 RID: 57480 RVA: 0x00255E80 File Offset: 0x00254080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HILGIGJMIFM != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HILGIGJMIFM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E089 RID: 57481 RVA: 0x00255EB4 File Offset: 0x002540B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HILGIGJMIFM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HILGIGJMIFM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E08A RID: 57482 RVA: 0x00255EF2 File Offset: 0x002540F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialBackGroundMusicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HILGIGJMIFM != 0U)
			{
				this.HILGIGJMIFM = other.HILGIGJMIFM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E08B RID: 57483 RVA: 0x00255F23 File Offset: 0x00254123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E08C RID: 57484 RVA: 0x00255F2C File Offset: 0x0025412C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HILGIGJMIFM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005969 RID: 22889
		private static readonly MessageParser<TrialBackGroundMusicCsReq> _parser = new MessageParser<TrialBackGroundMusicCsReq>(() => new TrialBackGroundMusicCsReq());

		// Token: 0x0400596A RID: 22890
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400596B RID: 22891
		public const int HILGIGJMIFMFieldNumber = 2;

		// Token: 0x0400596C RID: 22892
		private uint hILGIGJMIFM_;
	}
}
