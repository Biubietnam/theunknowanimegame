using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013C3 RID: 5059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockedAreaMapScNotify : IMessage<UnlockedAreaMapScNotify>, IMessage, IEquatable<UnlockedAreaMapScNotify>, IDeepCloneable<UnlockedAreaMapScNotify>, IBufferMessage
	{
		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0600E186 RID: 57734 RVA: 0x0025827C File Offset: 0x0025647C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockedAreaMapScNotify> Parser
		{
			get
			{
				return UnlockedAreaMapScNotify._parser;
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0600E187 RID: 57735 RVA: 0x00258283 File Offset: 0x00256483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockedAreaMapScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0600E188 RID: 57736 RVA: 0x00258295 File Offset: 0x00256495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockedAreaMapScNotify.Descriptor;
			}
		}

		// Token: 0x0600E189 RID: 57737 RVA: 0x0025829C File Offset: 0x0025649C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockedAreaMapScNotify()
		{
		}

		// Token: 0x0600E18A RID: 57738 RVA: 0x002582AF File Offset: 0x002564AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockedAreaMapScNotify(UnlockedAreaMapScNotify other) : this()
		{
			this.entryIdList_ = other.entryIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E18B RID: 57739 RVA: 0x002582D9 File Offset: 0x002564D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockedAreaMapScNotify Clone()
		{
			return new UnlockedAreaMapScNotify(this);
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0600E18C RID: 57740 RVA: 0x002582E1 File Offset: 0x002564E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EntryIdList
		{
			get
			{
				return this.entryIdList_;
			}
		}

		// Token: 0x0600E18D RID: 57741 RVA: 0x002582E9 File Offset: 0x002564E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockedAreaMapScNotify);
		}

		// Token: 0x0600E18E RID: 57742 RVA: 0x002582F7 File Offset: 0x002564F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockedAreaMapScNotify other)
		{
			return other != null && (other == this || (this.entryIdList_.Equals(other.entryIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E18F RID: 57743 RVA: 0x0025832C File Offset: 0x0025652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entryIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E190 RID: 57744 RVA: 0x00258360 File Offset: 0x00256560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E191 RID: 57745 RVA: 0x00258368 File Offset: 0x00256568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E192 RID: 57746 RVA: 0x00258371 File Offset: 0x00256571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entryIdList_.WriteTo(ref output, UnlockedAreaMapScNotify._repeated_entryIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E193 RID: 57747 RVA: 0x00258398 File Offset: 0x00256598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entryIdList_.CalculateSize(UnlockedAreaMapScNotify._repeated_entryIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E194 RID: 57748 RVA: 0x002583D1 File Offset: 0x002565D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockedAreaMapScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entryIdList_.Add(other.entryIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x002583FF File Offset: 0x002565FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x00258408 File Offset: 0x00256608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entryIdList_.AddEntriesFrom(ref input, UnlockedAreaMapScNotify._repeated_entryIdList_codec);
				}
			}
		}

		// Token: 0x040059C4 RID: 22980
		private static readonly MessageParser<UnlockedAreaMapScNotify> _parser = new MessageParser<UnlockedAreaMapScNotify>(() => new UnlockedAreaMapScNotify());

		// Token: 0x040059C5 RID: 22981
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059C6 RID: 22982
		public const int EntryIdListFieldNumber = 5;

		// Token: 0x040059C7 RID: 22983
		private static readonly FieldCodec<uint> _repeated_entryIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x040059C8 RID: 22984
		private readonly RepeatedField<uint> entryIdList_ = new RepeatedField<uint>();
	}
}
