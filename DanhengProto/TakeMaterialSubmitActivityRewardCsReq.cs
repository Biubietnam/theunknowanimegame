using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E7 RID: 4839
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMaterialSubmitActivityRewardCsReq : IMessage<TakeMaterialSubmitActivityRewardCsReq>, IMessage, IEquatable<TakeMaterialSubmitActivityRewardCsReq>, IDeepCloneable<TakeMaterialSubmitActivityRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600D7ED RID: 55277 RVA: 0x0023FE8D File Offset: 0x0023E08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMaterialSubmitActivityRewardCsReq> Parser
		{
			get
			{
				return TakeMaterialSubmitActivityRewardCsReq._parser;
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x0023FE94 File Offset: 0x0023E094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMaterialSubmitActivityRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600D7EF RID: 55279 RVA: 0x0023FEA6 File Offset: 0x0023E0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMaterialSubmitActivityRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x0023FEAD File Offset: 0x0023E0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMaterialSubmitActivityRewardCsReq()
		{
		}

		// Token: 0x0600D7F1 RID: 55281 RVA: 0x0023FEB5 File Offset: 0x0023E0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMaterialSubmitActivityRewardCsReq(TakeMaterialSubmitActivityRewardCsReq other) : this()
		{
			this.nCEJNFFMGGF_ = other.nCEJNFFMGGF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x0023FEDA File Offset: 0x0023E0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMaterialSubmitActivityRewardCsReq Clone()
		{
			return new TakeMaterialSubmitActivityRewardCsReq(this);
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600D7F3 RID: 55283 RVA: 0x0023FEE2 File Offset: 0x0023E0E2
		// (set) Token: 0x0600D7F4 RID: 55284 RVA: 0x0023FEEA File Offset: 0x0023E0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCEJNFFMGGF
		{
			get
			{
				return this.nCEJNFFMGGF_;
			}
			set
			{
				this.nCEJNFFMGGF_ = value;
			}
		}

		// Token: 0x0600D7F5 RID: 55285 RVA: 0x0023FEF3 File Offset: 0x0023E0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMaterialSubmitActivityRewardCsReq);
		}

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x0023FF01 File Offset: 0x0023E101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMaterialSubmitActivityRewardCsReq other)
		{
			return other != null && (other == this || (this.NCEJNFFMGGF == other.NCEJNFFMGGF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7F7 RID: 55287 RVA: 0x0023FF30 File Offset: 0x0023E130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCEJNFFMGGF != 0U)
			{
				num ^= this.NCEJNFFMGGF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7F8 RID: 55288 RVA: 0x0023FF6F File Offset: 0x0023E16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D7F9 RID: 55289 RVA: 0x0023FF77 File Offset: 0x0023E177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7FA RID: 55290 RVA: 0x0023FF80 File Offset: 0x0023E180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCEJNFFMGGF != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.NCEJNFFMGGF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D7FB RID: 55291 RVA: 0x0023FFB4 File Offset: 0x0023E1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCEJNFFMGGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCEJNFFMGGF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D7FC RID: 55292 RVA: 0x0023FFF2 File Offset: 0x0023E1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMaterialSubmitActivityRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCEJNFFMGGF != 0U)
			{
				this.NCEJNFFMGGF = other.NCEJNFFMGGF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7FD RID: 55293 RVA: 0x00240023 File Offset: 0x0023E223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7FE RID: 55294 RVA: 0x0024002C File Offset: 0x0023E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NCEJNFFMGGF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400562D RID: 22061
		private static readonly MessageParser<TakeMaterialSubmitActivityRewardCsReq> _parser = new MessageParser<TakeMaterialSubmitActivityRewardCsReq>(() => new TakeMaterialSubmitActivityRewardCsReq());

		// Token: 0x0400562E RID: 22062
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400562F RID: 22063
		public const int NCEJNFFMGGFFieldNumber = 15;

		// Token: 0x04005630 RID: 22064
		private uint nCEJNFFMGGF_;
	}
}
