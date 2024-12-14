using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200137D RID: 4989
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochurePageUnlockScNotify : IMessage<TravelBrochurePageUnlockScNotify>, IMessage, IEquatable<TravelBrochurePageUnlockScNotify>, IDeepCloneable<TravelBrochurePageUnlockScNotify>, IBufferMessage
	{
		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0600DE8F RID: 56975 RVA: 0x002505D1 File Offset: 0x0024E7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochurePageUnlockScNotify> Parser
		{
			get
			{
				return TravelBrochurePageUnlockScNotify._parser;
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0600DE90 RID: 56976 RVA: 0x002505D8 File Offset: 0x0024E7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochurePageUnlockScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x002505EA File Offset: 0x0024E7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochurePageUnlockScNotify.Descriptor;
			}
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x002505F1 File Offset: 0x0024E7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageUnlockScNotify()
		{
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x002505F9 File Offset: 0x0024E7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageUnlockScNotify(TravelBrochurePageUnlockScNotify other) : this()
		{
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x0025061E File Offset: 0x0024E81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageUnlockScNotify Clone()
		{
			return new TravelBrochurePageUnlockScNotify(this);
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0600DE95 RID: 56981 RVA: 0x00250626 File Offset: 0x0024E826
		// (set) Token: 0x0600DE96 RID: 56982 RVA: 0x0025062E File Offset: 0x0024E82E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMAKNJMFFJN
		{
			get
			{
				return this.nMAKNJMFFJN_;
			}
			set
			{
				this.nMAKNJMFFJN_ = value;
			}
		}

		// Token: 0x0600DE97 RID: 56983 RVA: 0x00250637 File Offset: 0x0024E837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochurePageUnlockScNotify);
		}

		// Token: 0x0600DE98 RID: 56984 RVA: 0x00250645 File Offset: 0x0024E845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochurePageUnlockScNotify other)
		{
			return other != null && (other == this || (this.NMAKNJMFFJN == other.NMAKNJMFFJN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x00250674 File Offset: 0x0024E874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x002506B3 File Offset: 0x0024E8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x002506BB File Offset: 0x0024E8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE9C RID: 56988 RVA: 0x002506C4 File Offset: 0x0024E8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE9D RID: 56989 RVA: 0x002506F8 File Offset: 0x0024E8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE9E RID: 56990 RVA: 0x00250736 File Offset: 0x0024E936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochurePageUnlockScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x00250767 File Offset: 0x0024E967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x00250770 File Offset: 0x0024E970
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
					this.NMAKNJMFFJN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400587D RID: 22653
		private static readonly MessageParser<TravelBrochurePageUnlockScNotify> _parser = new MessageParser<TravelBrochurePageUnlockScNotify>(() => new TravelBrochurePageUnlockScNotify());

		// Token: 0x0400587E RID: 22654
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400587F RID: 22655
		public const int NMAKNJMFFJNFieldNumber = 15;

		// Token: 0x04005880 RID: 22656
		private uint nMAKNJMFFJN_;
	}
}
