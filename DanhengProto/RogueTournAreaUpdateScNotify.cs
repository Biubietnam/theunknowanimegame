using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F81 RID: 3969
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournAreaUpdateScNotify : IMessage<RogueTournAreaUpdateScNotify>, IMessage, IEquatable<RogueTournAreaUpdateScNotify>, IDeepCloneable<RogueTournAreaUpdateScNotify>, IBufferMessage
	{
		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600B0BF RID: 45247 RVA: 0x001DAD6F File Offset: 0x001D8F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournAreaUpdateScNotify> Parser
		{
			get
			{
				return RogueTournAreaUpdateScNotify._parser;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600B0C0 RID: 45248 RVA: 0x001DAD76 File Offset: 0x001D8F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournAreaUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600B0C1 RID: 45249 RVA: 0x001DAD88 File Offset: 0x001D8F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournAreaUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x001DAD8F File Offset: 0x001D8F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournAreaUpdateScNotify()
		{
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x001DADA2 File Offset: 0x001D8FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournAreaUpdateScNotify(RogueTournAreaUpdateScNotify other) : this()
		{
			this.rogueTournAreaInfo_ = other.rogueTournAreaInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x001DADCC File Offset: 0x001D8FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournAreaUpdateScNotify Clone()
		{
			return new RogueTournAreaUpdateScNotify(this);
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600B0C5 RID: 45253 RVA: 0x001DADD4 File Offset: 0x001D8FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueTournAreaInfo> RogueTournAreaInfo
		{
			get
			{
				return this.rogueTournAreaInfo_;
			}
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x001DADDC File Offset: 0x001D8FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournAreaUpdateScNotify);
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x001DADEA File Offset: 0x001D8FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournAreaUpdateScNotify other)
		{
			return other != null && (other == this || (this.rogueTournAreaInfo_.Equals(other.rogueTournAreaInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x001DAE20 File Offset: 0x001D9020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueTournAreaInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x001DAE54 File Offset: 0x001D9054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0CA RID: 45258 RVA: 0x001DAE5C File Offset: 0x001D905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x001DAE65 File Offset: 0x001D9065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueTournAreaInfo_.WriteTo(ref output, RogueTournAreaUpdateScNotify._repeated_rogueTournAreaInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0CC RID: 45260 RVA: 0x001DAE8C File Offset: 0x001D908C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueTournAreaInfo_.CalculateSize(RogueTournAreaUpdateScNotify._repeated_rogueTournAreaInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0CD RID: 45261 RVA: 0x001DAEC5 File Offset: 0x001D90C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournAreaUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueTournAreaInfo_.Add(other.rogueTournAreaInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0CE RID: 45262 RVA: 0x001DAEF3 File Offset: 0x001D90F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0CF RID: 45263 RVA: 0x001DAEFC File Offset: 0x001D90FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueTournAreaInfo_.AddEntriesFrom(ref input, RogueTournAreaUpdateScNotify._repeated_rogueTournAreaInfo_codec);
				}
			}
		}

		// Token: 0x040047EE RID: 18414
		private static readonly MessageParser<RogueTournAreaUpdateScNotify> _parser = new MessageParser<RogueTournAreaUpdateScNotify>(() => new RogueTournAreaUpdateScNotify());

		// Token: 0x040047EF RID: 18415
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047F0 RID: 18416
		public const int RogueTournAreaInfoFieldNumber = 6;

		// Token: 0x040047F1 RID: 18417
		private static readonly FieldCodec<RogueTournAreaInfo> _repeated_rogueTournAreaInfo_codec = FieldCodec.ForMessage<RogueTournAreaInfo>(50U, EggLink.DanhengServer.Proto.RogueTournAreaInfo.Parser);

		// Token: 0x040047F2 RID: 18418
		private readonly RepeatedField<RogueTournAreaInfo> rogueTournAreaInfo_ = new RepeatedField<RogueTournAreaInfo>();
	}
}
