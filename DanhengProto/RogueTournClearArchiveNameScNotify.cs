using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F85 RID: 3973
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournClearArchiveNameScNotify : IMessage<RogueTournClearArchiveNameScNotify>, IMessage, IEquatable<RogueTournClearArchiveNameScNotify>, IDeepCloneable<RogueTournClearArchiveNameScNotify>, IBufferMessage
	{
		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x001DB3E9 File Offset: 0x001D95E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournClearArchiveNameScNotify> Parser
		{
			get
			{
				return RogueTournClearArchiveNameScNotify._parser;
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600B0EB RID: 45291 RVA: 0x001DB3F0 File Offset: 0x001D95F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournClearArchiveNameScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600B0EC RID: 45292 RVA: 0x001DB402 File Offset: 0x001D9602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournClearArchiveNameScNotify.Descriptor;
			}
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x001DB409 File Offset: 0x001D9609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournClearArchiveNameScNotify()
		{
		}

		// Token: 0x0600B0EE RID: 45294 RVA: 0x001DB411 File Offset: 0x001D9611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournClearArchiveNameScNotify(RogueTournClearArchiveNameScNotify other) : this()
		{
			this.maxTimes_ = other.maxTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x001DB436 File Offset: 0x001D9636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournClearArchiveNameScNotify Clone()
		{
			return new RogueTournClearArchiveNameScNotify(this);
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x001DB43E File Offset: 0x001D963E
		// (set) Token: 0x0600B0F1 RID: 45297 RVA: 0x001DB446 File Offset: 0x001D9646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x0600B0F2 RID: 45298 RVA: 0x001DB44F File Offset: 0x001D964F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournClearArchiveNameScNotify);
		}

		// Token: 0x0600B0F3 RID: 45299 RVA: 0x001DB45D File Offset: 0x001D965D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournClearArchiveNameScNotify other)
		{
			return other != null && (other == this || (this.MaxTimes == other.MaxTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0F4 RID: 45300 RVA: 0x001DB48C File Offset: 0x001D968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0F5 RID: 45301 RVA: 0x001DB4CB File Offset: 0x001D96CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0F6 RID: 45302 RVA: 0x001DB4D3 File Offset: 0x001D96D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0F7 RID: 45303 RVA: 0x001DB4DC File Offset: 0x001D96DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0F8 RID: 45304 RVA: 0x001DB510 File Offset: 0x001D9710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0F9 RID: 45305 RVA: 0x001DB54E File Offset: 0x001D974E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournClearArchiveNameScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0FA RID: 45306 RVA: 0x001DB57F File Offset: 0x001D977F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0FB RID: 45307 RVA: 0x001DB588 File Offset: 0x001D9788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.MaxTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040047FB RID: 18427
		private static readonly MessageParser<RogueTournClearArchiveNameScNotify> _parser = new MessageParser<RogueTournClearArchiveNameScNotify>(() => new RogueTournClearArchiveNameScNotify());

		// Token: 0x040047FC RID: 18428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047FD RID: 18429
		public const int MaxTimesFieldNumber = 3;

		// Token: 0x040047FE RID: 18430
		private uint maxTimes_;
	}
}
